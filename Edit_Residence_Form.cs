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
    public partial class Edit_Residence_Form : Form
    {
        public Edit_Residence_Form()
        {
            InitializeComponent();
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
                MySqlConnection con = Database.dbConnection.GetConnection();

                string updateQuery = "UPDATE resident_information SET firstName = @FirstName, lastName = @LastName, middleName = @MiddleName, " +
                                         "alias = @Alias, sex = @Sex, maritalStatus = @MaritalStatus, birthDate = @BirthDate, " +
                                         "age = @Age, religion = @Religion, job = @Job, photo = @Photo WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@id", lbl_id.Text);
                        cmd.Parameters.AddWithValue("@FirstName", tbx_firstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", tbx_lastName.Text);
                        cmd.Parameters.AddWithValue("@MiddleName", tbx_middleName.Text);
                        cmd.Parameters.AddWithValue("@Alias", tbx_alias.Text);
                        cmd.Parameters.AddWithValue("@Sex", rbt_Male.Checked ? "Male" : "Female");
                        cmd.Parameters.AddWithValue("@MaritalStatus", cmb_maritalStatus.Text);
                        cmd.Parameters.AddWithValue("@BirthDate", dtp_birthDate.Value.ToString("yyyy-MM-dd")); 
                        cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(tbx_Age.Text));
                        cmd.Parameters.AddWithValue("@Religion", cmb_religion.Text);
                        cmd.Parameters.AddWithValue("@Job", tbx_job.Text);
                        cmd.Parameters.AddWithValue("@Photo", SaveImageToDisk(picturebox_image.Image)); 
                       
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
    }
}
