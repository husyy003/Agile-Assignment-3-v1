using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class LogIn_Page : Form
    {
        SqlConnection sqlCon = 
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SqlDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public LogIn_Page()
        {
            InitializeComponent();
        }

        private void exitLogInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        //Client Login Button
        private void clientLogInButton_Click(object sender, EventArgs e)
        {
            string query = "Select * from [ClientData] Where ClientName = '" + ClientUserNameTextBox.Text.Trim() + "' and password = '" + ClientPasswordTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
               // MessageBox.Show("Login Successful");
               //
                ClientForm cf = new ClientForm();
                this.Hide();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Search", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@ContactName", ClientUserNameTextBox.Text.Trim());
                DataTable dtTable = new DataTable();
                sqlDa.Fill(dtTable);

                //***That's where we could fix values for client window
                cf.clientNameLabel.Text = "This is an example"; 
                cf.Show();
                
            }
            else
            {
                MessageBox.Show("check your username and password");
            }
        }


        //Contractor Login Button
        private void contractorLogInButton_Click(object sender, EventArgs e)
        {
            string query = "Select * from [ContractorData] Where ContractorName = '" + ContractorEmployeeIDTextBox.Text.Trim() + "' and password = '" + ContractorPasswordTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Contractor Login Successful");
            }
            else
            {
                MessageBox.Show("check your username and password");
            }
        }
    }
}
