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
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SqlDatabase.mdf;Integrated Security=True;Connect Timeout=30");
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





        private void clientNameTextBox_Click(object sender, EventArgs e)
        {
            clientNameTextBox.Text = "";
            clientNameTextBox.ForeColor = Color.Black;
        }

        private void ClientPasswordTextBox_Click(object sender, EventArgs e)
        {
            ClientPasswordTextBox.Text = "";
            ClientPasswordTextBox.ForeColor = Color.Black;
        }

        private void ClientAddressTextBox_Click(object sender, EventArgs e)
        {
            ClientAddressTextBox.Text = "";
            ClientAddressTextBox.ForeColor = Color.Black;
        }

        private void ClientLandLineNumberTextBox_Click(object sender, EventArgs e)
        {
            ClientLandLineNumberTextBox.Text = "";
            ClientLandLineNumberTextBox.ForeColor = Color.Black;
        }

        private void ClientMobileNumberTextBox_Click(object sender, EventArgs e)
        {
            ClientMobileNumberTextBox.Text = "";
            ClientMobileNumberTextBox.ForeColor = Color.Black;
        }

        private void ClientBusinessNameTextBox_Click(object sender, EventArgs e)
        {
            ClientBusinessNameTextBox.Text = "";
            ClientBusinessNameTextBox.ForeColor = Color.Black;
        }

        private void ClientEmailTextBox_Click(object sender, EventArgs e)
        {
            ClientEmailTextBox.Text = "";
            ClientEmailTextBox.ForeColor = Color.Black;
        }

        private void ContractorNameTextBox_Click(object sender, EventArgs e)
        {
            ContractorNameTextBox.Text = "";
            ContractorNameTextBox.ForeColor = Color.Black;
        }

        private void ContractorEmployeeIDTextBox_Click(object sender, EventArgs e)
        {
            ContractorEmployeeIDTextBox.Text = "";
            contractorLabel.ForeColor = Color.Black;
        }

        private void ContractorPasswordTextBox_Click(object sender, EventArgs e)
        {
            ContractorPasswordTextBox.Text = "";
            ContractorPasswordTextBox.ForeColor = Color.Black;
        }

        private void ContractorOccupationTextBox_Click(object sender, EventArgs e)
        {
            ContractorOccupationTextBox.Text = "";
            ContractorOccupationTextBox.ForeColor = Color.Black;
        }

        private void ContractorAddressTextBox_Click(object sender, EventArgs e)
        {
            ContractorAddressTextBox.Text = "";
            ContractorAddressTextBox.ForeColor = Color.Black;
        }

        private void ContractorLandLineNumberTextBox_Click(object sender, EventArgs e)
        {
            ContractorLandLineNumberTextBox.Text = "";
            ContractorLandLineNumberTextBox.ForeColor = Color.Black;
        }

        private void ContractorMobileNumberTextBox_Click(object sender, EventArgs e)
        {
            ContractorMobileNumberTextBox.Text = "";
            ContractorMobileNumberTextBox.ForeColor = Color.Black;
        }

        private void ContractorEmailTextBox_Click(object sender, EventArgs e)
        {
            ContractorEmailTextBox.Text = "";
            ContractorEmailTextBox.ForeColor = Color.Black;
        }
    }
}
