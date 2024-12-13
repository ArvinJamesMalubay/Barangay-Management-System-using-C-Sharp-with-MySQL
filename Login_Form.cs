using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Management_System
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_username.Text != string.Empty || tbx_password.Text != string.Empty)
                {

                    MySqlConnection con = Database.dbConnection.GetConnection();
                    string querry = "Select username, password from user Where username = '" + tbx_username.Text + "' and password = '" + tbx_password.Text + "' "; 
                    MySqlCommand cmd = new MySqlCommand(querry, con);

                    MySqlDataReader reader;

                    try
                    {
                        
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show("Welcome " + tbx_username.Text);
                                Main_Form form = new Main_Form();

                                form.Show();
                                this.Hide();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Oops! Something went wrong.");
                        }
                        con.Close();

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Please fill up the missing information!");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void tbx_password_TextChanged(object sender, EventArgs e)
        {
            tbx_password.PasswordChar = '*';
        }

        private void lbl_createAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if (true)
            {
                Register_Form form = new Register_Form();
                form.Show();

                this.Hide();
            }
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
