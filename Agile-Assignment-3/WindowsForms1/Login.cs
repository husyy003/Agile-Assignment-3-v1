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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yasir\Documents\DB\SqlDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from [Table] Where userName = '" + userNameTextBox.Text.Trim() + "' and password = '" + passwordTextBox.Text.Trim() +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if(dataTable.Rows.Count==1)
            {
                MessageBox.Show("works");
            }
            else
            {
                MessageBox.Show("check your username and password");
            }


        }
    }
}
