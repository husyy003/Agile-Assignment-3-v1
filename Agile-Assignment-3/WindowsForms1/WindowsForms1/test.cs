using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsForms1
{
    public partial class test : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yasir\Documents\DB\SqlDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public test()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("Save", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Save");
                    sqlCmd.Parameters.AddWithValue("@LoginId", usernameTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@userName", usernameTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", passwordTextBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Succesfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
