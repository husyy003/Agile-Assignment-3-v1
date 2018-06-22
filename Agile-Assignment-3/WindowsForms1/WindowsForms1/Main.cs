using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
         //   CF.Size = new System.Drawing.Size(400, 340);
        }

        private void contractorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContractorForm CTF = new ContractorForm();
            CTF.Show();
        }

        private void signUpLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp sp = new SignUp();
            sp.Show();
        }

        private void logInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LogIn_Page lp = new LogIn_Page();
            lp.Show();
        }
    }
}
