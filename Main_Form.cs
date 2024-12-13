using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace Barangay_Management_System
{
    public partial class Main_Form : Form
    {
        private Timer timer;
        public Main_Form()
        {
            InitializeComponent();
            btn_newResident.Click += btn_newResident_Click;
            btn_residentRecords.Click += btn_residentRecords_Click;
            btn_home.Click += btn_home_Click;
            btn_brgyOfficials.Click += btn_brgyOfficials_Click;
            btn_user.Click += btn_user_Click;
            timer1 = new Timer();
            timer1.Interval = 1000; // Update every 1000 milliseconds (1 second)
            timer1.Tick += timer1_Tick;
            timer1.Start();

            // Initial update
            UpdateTime();
        }

        private void btn_newResident_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        public void display_residence()
        {
            Functions.display("Select Concat(firstName, ' ', lastName) as Full_Name, alias, sex, age, job From resident_information", dgv_residentInformation);
        }
        public void display_officials()
        {
            Functions.display("Select Concat(firstName, ' ', lastName) as Full_Name, committee, position From brgy_officials", dgv_brgyOfficials);
        }
        private void btn_residentRecords_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            try
            {
                display_residence();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }
        private void btn_brgyOfficials_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }
        private void btn_user_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_logout.Text == "Logout")
                {
                    if (MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == (DialogResult.Yes))
                    {
                        Login_Form form = new Login_Form();
                        form.Show();
                        this.Hide();
                    }
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        void clear_officials()
        {
            tbx_off_firstName.Clear();
            tbx_off_lastName.Clear();
            tbx_off_middleName.Clear();
            cmb_off_position.Text = "";
            tbx_off_religion.Clear();
            cmb_off_committee.Text = "";
        }
        void clear_residents()
        {
            tbx_firstName.Clear();
            tbx_lastName.Clear();
            tbx_middleName.Clear();
            tbx_job.Clear();
            tbx_alias.Clear();
            tbx_Age.Clear();
            cmb_maritalStatus.Text = "";
            cmb_religion.Text = "";
            picturebox_image.Image = null;
        }
        void clear_userAccounts()
        {
            tbx_user_firstName.Clear();
            tbx_user_lastName.Clear();
            tbx_user_middleName.Clear();
            tbx_user_password.Clear();
            tbx_user_userName.Clear();
            tbx_user_position.Clear();
        }
        private void btn_off_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbx_off_firstName.Text != string.Empty || tbx_off_lastName.Text != string.Empty
                    || tbx_off_middleName.Text != string.Empty || cmb_off_position.Text != string.Empty
                    || tbx_off_religion.Text != string.Empty || cmb_off_committee.Text != string.Empty)
                {
                    string firstName = tbx_off_firstName.Text;
                    string lastName = tbx_off_lastName.Text;
                    string middlename = tbx_off_middleName.Text;
                    string sex = rbt_off_Male.Checked ? "Male" : "Female";

                    string birthdate = dtp_off_birthDate.Value.ToString("yyyy-MM-dd");


                    string position = cmb_off_position.Text;
                    string religion = tbx_off_religion.Text;
                    string committee = cmb_off_committee.Text;

                    MySqlConnection con = Database.dbConnection.GetConnection();
                    string query = "INSERT INTO brgy_officials (firstName, lastName,middleName, sex, birthdate, position, religion, committee ) " +
                            "VALUES (@firstName, @lastName, @middlename, @sex, @birthdate, @position, @religion, @committee)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@middlename", middlename);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@birthdate", birthdate);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@religion", religion);
                    cmd.Parameters.AddWithValue("@committee", committee);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        if(MessageBox.Show("Please Confirm information!!", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            MessageBox.Show("Registration successful!");
                            clear_officials();
                        }
                        return;
                       
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }

                }
                else
                {
                    MessageBox.Show("Please Fill up the missing information!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tbx_off_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a letter or control key, cancel the key press
                e.Handled = true;
            }
        }
        private string SaveImageToDisk(Image image)
        {
           
            string folderPath = "C:\\Users\\Dell\\Desktop\\resource\\Images";
            string fileName = Guid.NewGuid().ToString() + ".png";

            string filePath = Path.Combine(folderPath, fileName);
            image.Save(filePath);

            return filePath;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbx_firstName.Text != string.Empty && tbx_lastName.Text != string.Empty
                    && tbx_middleName.Text != string.Empty && tbx_alias.Text != string.Empty
                    && cmb_maritalStatus.Text != string.Empty && tbx_Age.Text != string.Empty
                    && cmb_religion.Text != string.Empty && tbx_job.Text != string.Empty
                    && picturebox_image.Image != null)
                {
                    
                    string firstName = tbx_firstName.Text;
                    string lastName = tbx_lastName.Text;
                    string middlename = tbx_middleName.Text;
                    string alias = tbx_alias.Text;
                    string sex = rbt_Male.Checked ? "Male" : "Female";
                    string birthdate = dtp_birthDate.Value.ToString("yyyy-MM-dd");
                    string maritalStatus = cmb_maritalStatus.Text;
                    string age = tbx_Age.Text;
                    string religion = cmb_religion.Text;
                    string job = tbx_job.Text;
                    string imagePath = SaveImageToDisk(picturebox_image.Image);

                   
                   
                    MySqlConnection con = Database.dbConnection.GetConnection();
                    string query = "INSERT INTO resident_information (firstName, lastName,middleName, alias, sex,maritalStatus, birthDate,age,religion, job, photo ) " +
                            "VALUES (@firstName, @lastName, @middleName,@alias, @sex, @maritalStatus, @birthDate, @age, @religion, @job, @photo)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@middleName", middlename);
                    cmd.Parameters.AddWithValue("@alias", alias);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.Parameters.AddWithValue("@maritalStatus", maritalStatus);
                    cmd.Parameters.AddWithValue("@birthDate", birthdate);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@religion", religion);
                    cmd.Parameters.AddWithValue("@job", job);
                    cmd.Parameters.AddWithValue("@photo", imagePath);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                       MessageBox.Show("Registration successful!");
                       clear_residents();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Fill up the missing information!");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void picturebox_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    picturebox_image.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void tbx_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a letter or control key, cancel the key press
                e.Handled = true;
            }
        }

        private void tbx_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
            if (tbx_Age.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(tbx_search.Text != string.Empty)
                {
                    MySqlConnection con = Database.dbConnection.GetConnection();
                    string querry = "Select Concat(firstName,' ',lastName) as Full_Name, alias, sex, age, job From resident_information Where firstName Like '" + tbx_search.Text + "' '" + "%" + "'";

                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv_residentInformation.DataSource = dt;

                    con.Close();
                }
                else
                {
                    MySqlConnection con = Database.dbConnection.GetConnection();
                    string querry = "Select Concat(firstName,' ',lastName) as Full_Name, alias, sex, age, job From resident_information";

                    MySqlCommand cmd = new MySqlCommand(querry, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv_residentInformation.DataSource = dt;

                    con.Close();
                }
               

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

       
        private void Main_Form_Load(object sender, EventArgs e)
        {
            try
            {
                display_officials();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void dgv_residentInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                //Edit
                MySqlConnection con = Database.dbConnection.GetConnection();
                Edit_Residence_Form form = new Edit_Residence_Form();

                string query = "Select * from resident_information where firstName = @firstName";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    string fullName = dgv_residentInformation.Rows[e.RowIndex].Cells[2].Value.ToString();

                   
                    string[] names = fullName.Split(' ');
                    string firstName = names[0];
                    string lastName = names.Length > 1 ? names[1] : string.Empty;

                    cmd.Parameters.AddWithValue("@firstName", firstName);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            form.lbl_id.Text = reader["id"].ToString();
                            form.tbx_firstName.Text = reader["firstName"].ToString();
                            form.tbx_lastName.Text = reader["lastName"].ToString();
                            form.tbx_middleName.Text = reader["middleName"].ToString();
                            form.dtp_birthDate.Value = (DateTime)reader["birthdate"];
                            form.tbx_alias.Text = reader["alias"].ToString();
                            form.cmb_maritalStatus.Text = reader["maritalStatus"].ToString();
                            form.tbx_Age.Text = reader["age"].ToString();
                            form.cmb_religion.Text = reader["religion"].ToString();
                            form.tbx_job.Text = reader["job"].ToString();
                            
                        }
                    }
                    con.Close();
                }
                form.btn_save.Text = "Save";
                form.ShowDialog();
                display_residence();
            }

            if (e.ColumnIndex == 1)
            {
                // Delete
                if (MessageBox.Show("Are you sure you want to delete this field?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MySqlConnection con = Database.dbConnection.GetConnection();

                    
                     // Assuming first name is in the second column and last name is in the third column
                    string fullname = dgv_residentInformation.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string[] names = fullname.Split(' ');
                    string firstName = names[0];
                    string lastName = names.Length > 1 ? names[1] : string.Empty;

                        // Perform the deletion operation
                    string deleteQuery = "DELETE FROM resident_information WHERE firstName = @firstName";
                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con))
                    {
                        deleteCmd.Parameters.AddWithValue("@firstName", firstName);
                       
                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Field deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            display_residence();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void dgv_brgyOfficials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                //Edit
                MySqlConnection con = Database.dbConnection.GetConnection();
                Edit_Official_form form = new Edit_Official_form();

                string query = "Select * from brgy_officials where firstName = @firstName";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                   
                    string fullName = dgv_brgyOfficials.Rows[e.RowIndex].Cells[2].Value.ToString();

                    string[] names = fullName.Split(' ');
                    string firstName = names[0];
                    string lastName = names.Length > 1 ? names[1] : string.Empty;

                    cmd.Parameters.AddWithValue("@firstName", firstName);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            form.lbl_id.Text = reader["id"].ToString();
                            form.tbx_off_firstName.Text = reader["firstName"].ToString();
                            form.tbx_off_lastName.Text = reader["lastName"].ToString();
                            form.tbx_off_middleName.Text = reader["middleName"].ToString();
                            form.dtp_off_birthDate.Value = (DateTime)reader["birthdate"];
                            form.tbx_off_religion.Text = reader["religion"].ToString();
                            form.cmb_off_committee.Text = reader["committee"].ToString();
                            form.cmb_off_position.Text = reader["position"].ToString();
                          
                        }
                    }
                    con.Close();
                }
                form.btn_off_save.Text = "Save";
                form.ShowDialog();
                display_officials();
                
            }

            if (e.ColumnIndex == 1)
            {
                // Delete
                if (MessageBox.Show("Are you sure you want to delete this field?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    MySqlConnection con = Database.dbConnection.GetConnection();


                    // Assuming first name is in the second column and last name is in the third column
                    string fullname = dgv_brgyOfficials.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string[] names = fullname.Split(' ');
                    string firstName = names[0];
                    string lastName = names.Length > 1 ? names[1] : string.Empty;

                    // Perform the deletion operation
                    string deleteQuery = "DELETE FROM brgy_officials WHERE firstName = @firstName";
                    using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con))
                    {
                        deleteCmd.Parameters.AddWithValue("@firstName", firstName);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Field deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            display_officials();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            // Get current time
            DateTime currentTime = DateTime.Now;

            // Update label or any other UI element with the current time
            lbl_Time.Text = currentTime.ToString("HH:mm:ss");
        }

        private void certificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Barangay_Certificate_Form form = new Barangay_Certificate_Form();
                form.ShowDialog();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Barangay_Indigency_Form form = new Barangay_Indigency_Form();
                form.ShowDialog();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Barangay_Clearance_Form form = new Barangay_Clearance_Form();
                form.ShowDialog();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_user_Save_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrWhiteSpace(tbx_user_firstName.Text) &&
                    !string.IsNullOrWhiteSpace(tbx_user_lastName.Text) &&
                    !string.IsNullOrWhiteSpace(tbx_user_middleName.Text) &&
                    !string.IsNullOrWhiteSpace(tbx_user_password.Text) &&
                    !string.IsNullOrWhiteSpace(tbx_user_userName.Text) &&
                    !string.IsNullOrWhiteSpace(tbx_user_position.Text) &&
                        dtp_user_birthDate.Value != DateTime.MinValue)
                {

                    string firstName = tbx_user_firstName.Text;
                    string lastName = tbx_user_lastName.Text;
                    string middlename = tbx_user_middleName.Text;
                    string sex = rbt_user_Male.Checked ? "Male" : "Female";
                    string birthdate = dtp_user_birthDate.Value.ToString("yyyy-MM-dd");
                    string position = tbx_user_position.Text;
                    string username = tbx_user_userName.Text;
                    string password = tbx_user_password.Text;
                 
                    MySqlConnection con = Database.dbConnection.GetConnection();
                    string query = "INSERT INTO user_Accounts (firstName, lastName,middleName,sex, birthDate, position, username, password ) " +
                            "VALUES (@firstName, @lastName, @middleName, @sex,  @birthDate, @position, @username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@middleName", middlename);    
                    cmd.Parameters.AddWithValue("@sex", sex);   
                    cmd.Parameters.AddWithValue("@birthDate", birthdate);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);


                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
                        clear_userAccounts();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill up the missing information!");

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        void display_users()
        {
            Functions.display("SELECT fullName, morning_TimeIn, morning_TimeOut, afternoon_TimeIn" +
                ", afternoon_TimeOut, date FROM brgy_attendance", dgv_attendance);
        }
       
        private void tabControl2_Click(object sender, EventArgs e)
        {
            try
            {
                display_users();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_user_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                display_users();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tbx_user_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbx_user_search.Text != string.Empty)
                {
                    MySqlConnection con = Database.dbConnection.GetConnection();
                    string query = "SELECT fullName, morning_TimeIn, morning_TimeOut, afternoon_TimeIn, afternoon_TimeOut, date " +
                "FROM brgy_attendance WHERE fullName LIKE @searchText";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@searchText", tbx_user_search.Text + "%");


                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv_attendance.DataSource = dt;

                    con.Close();
                }
                else
                {
                    display_users();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
