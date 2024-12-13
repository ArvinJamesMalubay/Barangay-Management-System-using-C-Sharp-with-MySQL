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

namespace Barangay_Management_System
{
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }
        void clear()
        {
            tbx_firstName.Clear();
            tbx_lastName.Clear();
            tbx_password.Clear();
            tbx_userName.Clear();

        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbx_firstName.Text != string.Empty || tbx_lastName.Text != string.Empty 
                    || tbx_password.Text != string.Empty || tbx_userName.Text != string.Empty)
                {
                    string firstName = tbx_firstName.Text;
                    string lastName = tbx_lastName.Text;
                    string username = tbx_userName.Text;
                    string password = tbx_password.Text;
                    string confirmPassword = tbx_confirmPassword.Text;
                    string gender = rbt_Male.Checked ? "Male" : "Female";

                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Password and Confirm Password do not match. Please try again.");
                        return; // Exit the method without proceeding further
                    }
                    else 
                    {
                        MySqlConnection con = Database.dbConnection.GetConnection();
                        string query = "INSERT INTO user (firstName, lastName,sex, username, password ) " +
                            "VALUES (@firstName, @lastName, @sex, @username, @password)";

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@sex", gender);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!");
                            clear();
                            Login_Form form = new Login_Form();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Fill up the missing information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tbx_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a letter or control key, cancel the key press
                e.Handled = true;
            }
        }

        private void tbx_password_TextChanged(object sender, EventArgs e)
        {
            tbx_password.PasswordChar = '*';
            tbx_confirmPassword.PasswordChar = '*';
        }

        private void lbl_signIn_MouseClick(object sender, MouseEventArgs e)
        {
            if (true)
            {
                Login_Form form = new Login_Form();
                form.Show();
                this.Hide();
            }
        }
    }
}
