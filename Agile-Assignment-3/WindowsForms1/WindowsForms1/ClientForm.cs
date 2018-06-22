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
    public partial class ClientForm : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SqlDatabase.mdf;Integrated Security=True;Connect Timeout=30s");
        public ClientForm()
        {
            InitializeComponent();
            //Just testing remvoe tis 
           
            // this.Size(409, 340);
           
            // this.Size = new Size(400, 340);
            
        }

        private void jobButton_Click(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void priorityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priorityLabel_Click(object sender, EventArgs e)
        {

        }

        private void locationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void locationLabel_Click(object sender, EventArgs e)
        {

        }

        private void jobDiscriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void jobDiscriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void joblabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        //Function to find userName
        void FillDataGridView()
        {
            if(sqlCon.State==ConnectionState.Closed)
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Search", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@ContactName", searchTextBox.Text.Trim());
                DataTable dtTable = new DataTable();
                sqlDa.Fill(dtTable);
                jobsDataGridView.DataSource = dtTable;
                sqlCon.Close();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
