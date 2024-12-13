using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Management_System
{
    class Functions
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=barangay_management_system";
            MySqlConnection connectionstring = new MySqlConnection(sql);
            try
            {
                connectionstring.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connectionstring;
        }
        public static void display(string querry, DataGridView dgv)
        {
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(querry, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dgv.DataSource = dt;
            con.Close();
        }

    }
}
