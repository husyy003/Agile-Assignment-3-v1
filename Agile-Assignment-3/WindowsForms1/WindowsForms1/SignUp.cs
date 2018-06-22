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
    public partial class SignUp : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yasir\Documents\DB\SqlDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUp()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }


        //Create Contractor Account
        private void createContractorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("ContractorSave", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "ContractorSave");
                    sqlCmd.Parameters.AddWithValue("@ContractorName", ContractorNameTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EmployeeID", ContractorEmployeeIDTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Occupation", ContractorOccupationTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", ContractorAddressTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LandLineNumber", ContractorLandLineNumberTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MobileNumber", ContractorMobileNumberTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", ContractorEmailTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", ContractorPasswordTextBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Succesfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        //Create Client Account
        private void createClientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("ClientSave", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "ClientSave");
                    sqlCmd.Parameters.AddWithValue("@ClientID", 0);
                    sqlCmd.Parameters.AddWithValue("@Address",  ClientAddressTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ClientName", clientNameTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MobileNumber", ClientMobileNumberTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@BusinessName", ClientBusinessNameTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", ClientEmailTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LandLineNumber", ClientLandLineNumberTextBox.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", ClientPasswordTextBox.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                   
                    MessageBox.Show("Saved Succesfully");
                }
            }
            catch (Exception ex)
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
