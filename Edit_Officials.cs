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
    public partial class Edit_Official_form : Form
    {
        public Edit_Official_form()
        {
            InitializeComponent();
        }

        private void btn_off_save_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Database.dbConnection.GetConnection();

                string updateQuery = "UPDATE brgy_officials SET firstName = @FirstName, lastName = @LastName, middleName = @MiddleName, " +
                    "sex = @Sex,  birthdate = @BirthDate, position = @Position, religion = @Religion, committee = @Committee WHERE id = @Id";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                {

                    cmd.Parameters.AddWithValue("@Id", lbl_id.Text);
                    cmd.Parameters.AddWithValue("@FirstName", tbx_off_firstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", tbx_off_lastName.Text);
                    cmd.Parameters.AddWithValue("@MiddleName", tbx_off_middleName.Text);
                    cmd.Parameters.AddWithValue("@Sex", rbt_off_Male.Checked ? "Male" : "Female");
                    cmd.Parameters.AddWithValue("@BirthDate", dtp_off_birthDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Position", cmb_off_position.Text);
                    cmd.Parameters.AddWithValue("@Religion", tbx_off_religion.Text);
                    cmd.Parameters.AddWithValue("@Committee", cmb_off_committee.Text);
        
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
    }
}
