using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Management_System
{
    public partial class Barangay_Attendance_form : Form
    {
        public Barangay_Attendance_form()
        {
            InitializeComponent();
            RefreshDataGridView();
            //timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Barangay_Attendance_form_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        void clear()
        {
            tbx_userName.Clear();
            tbx_password.Clear();
        }

        private void btn_timeIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_userName.Text != string.Empty || tbx_password.Text != string.Empty)
                {

                    MySqlConnection con = Database.dbConnection.GetConnection();


                    // Assuming you have a 'user' table with 'firstName' and 'lastName' columns
                    string username = tbx_userName.Text; // Replace with your actual username

                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    string loginTime = DateTime.Now.ToString("HH:mm:ss");

                    // Fetching first name and last name from the 'user' table based on the username
                    string userQuery = "SELECT firstName, lastName FROM user_accounts WHERE username = @username";
                    MySqlCommand userCmd = new MySqlCommand(userQuery, con);
                    userCmd.Parameters.AddWithValue("@username", username);

                    MySqlDataReader userReader;
                    string fullName = ""; // Initialize fullName here
                    try
                    {
                        userReader = userCmd.ExecuteReader();
                        if (userReader.HasRows)
                        {
                            // Assuming there's only one record for a given username
                            userReader.Read();
                            string firstName = userReader["firstName"].ToString();
                            string lastName = userReader["lastName"].ToString();
                            fullName = $"{firstName} {lastName}";
                            userReader.Close();

                            string query = "SELECT fullName, morning_TimeIn, afternoon_TimeIn FROM brgy_attendance WHERE fullName = @fullName AND date = @currentDate";
                            MySqlCommand selectCmd = new MySqlCommand(query, con);
                            selectCmd.Parameters.AddWithValue("@fullName", fullName);
                            selectCmd.Parameters.AddWithValue("@currentDate", currentDate);


                            MySqlDataReader reader;
                            try
                            {
                                reader = selectCmd.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    
                                    while (reader.Read())
                                    {
                                        string timeColumn = (reader["morning_TimeIn"] is DBNull) ? "morning_TimeIn" : "afternoon_TimeIn";

                                        if (reader[timeColumn] is DBNull)
                                        {
                                           
                                            reader.Close();
                                            string updateQuery = $"UPDATE brgy_attendance SET {timeColumn} = @loginTime WHERE fullName = @fullName AND date = @currentDate";
                                            MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                                            updateCmd.Parameters.AddWithValue("@fullName", fullName);
                                            updateCmd.Parameters.AddWithValue("@loginTime", loginTime);
                                            updateCmd.Parameters.AddWithValue("@currentDate", currentDate);
                                            updateCmd.ExecuteNonQuery();
                                            MessageBox.Show($"{timeColumn} added for {fullName} at {loginTime}");
                                            display_data();
                                            clear();
                                        }
                                        else
                                        {
                                            MessageBox.Show($"{timeColumn} already recorded for {fullName}");
                                            clear();
                                        }
                                    }
                                    reader.Close();
                                }
                                else
                                {
                                    reader.Close();
                                    string insertQuery = $"INSERT INTO brgy_attendance (fullName, morning_TimeIn, afternoon_TimeIn, date) VALUES (@fullName, @loginTime, NULL, @currentDate)";
                                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                                    insertCmd.Parameters.AddWithValue("@fullName", fullName);
                                    insertCmd.Parameters.AddWithValue("@loginTime", loginTime);
                                    insertCmd.Parameters.AddWithValue("@currentDate", currentDate);
                                    insertCmd.ExecuteNonQuery();
                                    MessageBox.Show($"Welcome {fullName}! Morning login time added: {loginTime}");
                                    clear();
                                    display_data();
                                }
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void btn_timeOut_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbx_userName.Text != string.Empty || tbx_password.Text != string.Empty)
                {

                    MySqlConnection con = Database.dbConnection.GetConnection();


                    // Assuming you have a 'user' table with 'firstName' and 'lastName' columns
                    string username = tbx_userName.Text; // Replace with your actual username

                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    string loginTime = DateTime.Now.ToString("HH:mm:ss");

                    // Fetching first name and last name from the 'user' table based on the username
                    string userQuery = "SELECT firstName, lastName FROM user_accounts WHERE username = @username";
                    MySqlCommand userCmd = new MySqlCommand(userQuery, con);
                    userCmd.Parameters.AddWithValue("@username", username);

                    MySqlDataReader userReader;
                    string fullName = ""; // Initialize fullName here
                    try
                    {
                        userReader = userCmd.ExecuteReader();
                        if (userReader.HasRows)
                        {
                            // Assuming there's only one record for a given username
                            userReader.Read();
                            string firstName = userReader["firstName"].ToString();
                            string lastName = userReader["lastName"].ToString();
                            fullName = $"{firstName} {lastName}";
                            userReader.Close();
                            string query = "SELECT fullName, morning_TimeOut, afternoon_TimeOut FROM brgy_attendance WHERE fullName = @fullName AND date = @currentDate";
                            MySqlCommand selectCmd = new MySqlCommand(query, con);
                            selectCmd.Parameters.AddWithValue("@fullName", fullName);
                            selectCmd.Parameters.AddWithValue("@currentDate", currentDate);


                        MySqlDataReader reader;
                        try
                        {
                            reader = selectCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                // Record exists, perform an UPDATE
                                while (reader.Read())
                                {
                                    // Determine the appropriate time column dynamically

                                    string timeColumn = (reader["morning_TimeOut"] is DBNull) ? "morning_TimeOut" : "afternoon_TimeOut";

                                    // Check if the timeColumn is null (indicating no login yet)
                                    if (reader[timeColumn] is DBNull)
                                    {
                                        // Perform the UPDATE to add the login time
                                        reader.Close();
                                        string updateQuery = $"UPDATE brgy_attendance SET {timeColumn} = @loginTime WHERE fullName = @fullName AND date = @currentDate";
                                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                                        updateCmd.Parameters.AddWithValue("@fullName", fullName);
                                        updateCmd.Parameters.AddWithValue("@loginTime", loginTime);
                                        updateCmd.Parameters.AddWithValue("@currentDate", currentDate);
                                        updateCmd.ExecuteNonQuery();
                                        MessageBox.Show($"{timeColumn} added for {fullName} at {loginTime}");
                                        clear();
                                        display_data();
                                    }
                                    else
                                    {
                                            MessageBox.Show($"{timeColumn} already recorded for {fullName}");
                                            clear();
                                            display_data();
                                    }
                                }
                                reader.Close();
                            }
                            else
                                {
                                // Record does not exist, perform an INSERT
                                reader.Close();
                                string insertQuery = $"INSERT INTO brgy_attendance (fullName, morning_TimeOut, afternoon_TimeOut, date) VALUES (@fullName, @loginTime, NULL, @currentDate)";
                                MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                                insertCmd.Parameters.AddWithValue("@fullName", fullName);
                                insertCmd.Parameters.AddWithValue("@loginTime", loginTime);
                                insertCmd.Parameters.AddWithValue("@currentDate", currentDate);
                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show($"Welcome {fullName}! Morning logout time added: {loginTime}");
                                clear();
                                display_data();
                                }
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message);
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        void display_data()
        {
            Functions.display("SELECT fullName, morning_TimeIn, morning_TimeOut, afternoon_TimeIn" +
                ", afternoon_TimeOut, date FROM brgy_attendance", dgv_attendance);
        }
        private void RefreshDataGridView()
        {
            try
            {
                display_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //RefreshDataGridView();
        }


    }
}
