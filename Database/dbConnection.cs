using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Management_System.Database
{
    class dbConnection
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
    }
}
