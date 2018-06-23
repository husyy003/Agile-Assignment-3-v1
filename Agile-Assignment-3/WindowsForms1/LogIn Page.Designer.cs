namespace WindowsForms1
{
    partial class LogIn_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logInTabControl = new System.Windows.Forms.TabControl();
            this.clientLogInTabPage = new System.Windows.Forms.TabPage();
            this.clientLogInButton = new System.Windows.Forms.Button();
            this.clientLabel = new System.Windows.Forms.Label();
            this.ClientPasswordLogInTextBox = new System.Windows.Forms.TextBox();
            this.ClientUserNameLogInTextBox = new System.Windows.Forms.TextBox();
            this.passwordLogInClientLabel = new System.Windows.Forms.Label();
            this.usrnameLogInClientLabel = new System.Windows.Forms.Label();
            this.contractorLogInTabPage = new System.Windows.Forms.TabPage();
            this.contractorLogInButton = new System.Windows.Forms.Button();
            this.ContractorPasswordLogInTextBox = new System.Windows.Forms.TextBox();
            this.ContractorEmployeeIDLogInTextBox = new System.Windows.Forms.TextBox();
            this.passwordLogInContractorLabel = new System.Windows.Forms.Label();
            this.employeeIDLogInContractorLabel = new System.Windows.Forms.Label();
            this.contractorLabel = new System.Windows.Forms.Label();
            this.exitLogInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.logInTabControl.SuspendLayout();
            this.clientLogInTabPage.SuspendLayout();
            this.contractorLogInTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInTabControl
            // 
            this.logInTabControl.Controls.Add(this.clientLogInTabPage);
            this.logInTabControl.Controls.Add(this.contractorLogInTabPage);
            this.logInTabControl.Location = new System.Drawing.Point(6, 3);
            this.logInTabControl.Name = "logInTabControl";
            this.logInTabControl.SelectedIndex = 0;
            this.logInTabControl.Size = new System.Drawing.Size(321, 274);
            this.logInTabControl.TabIndex = 0;
            // 
            // clientLogInTabPage
            // 
            this.clientLogInTabPage.Controls.Add(this.clientLogInButton);
            this.clientLogInTabPage.Controls.Add(this.clientLabel);
            this.clientLogInTabPage.Controls.Add(this.ClientPasswordLogInTextBox);
            this.clientLogInTabPage.Controls.Add(this.ClientUserNameLogInTextBox);
            this.clientLogInTabPage.Controls.Add(this.passwordLogInClientLabel);
            this.clientLogInTabPage.Controls.Add(this.usrnameLogInClientLabel);
            this.clientLogInTabPage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLogInTabPage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clientLogInTabPage.Location = new System.Drawing.Point(4, 22);
            this.clientLogInTabPage.Name = "clientLogInTabPage";
            this.clientLogInTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientLogInTabPage.Size = new System.Drawing.Size(313, 248);
            this.clientLogInTabPage.TabIndex = 0;
            this.clientLogInTabPage.Text = "Client";
            this.clientLogInTabPage.UseVisualStyleBackColor = true;
            // 
            // clientLogInButton
            // 
            this.clientLogInButton.Location = new System.Drawing.Point(204, 169);
            this.clientLogInButton.Name = "clientLogInButton";
            this.clientLogInButton.Size = new System.Drawing.Size(75, 28);
            this.clientLogInButton.TabIndex = 67;
            this.clientLogInButton.Text = "LogIn";
            this.clientLogInButton.UseVisualStyleBackColor = true;
            this.clientLogInButton.Click += new System.EventHandler(this.clientLogInButton_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.clientLabel.Location = new System.Drawing.Point(76, 28);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(132, 23);
            this.clientLabel.TabIndex = 66;
            this.clientLabel.Text = "Client";
            this.clientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientPasswordLogInTextBox
            // 
            this.ClientPasswordLogInTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ClientPasswordLogInTextBox.Location = new System.Drawing.Point(134, 126);
            this.ClientPasswordLogInTextBox.Name = "ClientPasswordLogInTextBox";
            this.ClientPasswordLogInTextBox.Size = new System.Drawing.Size(145, 25);
            this.ClientPasswordLogInTextBox.TabIndex = 1;
            this.ClientPasswordLogInTextBox.Text = "Password";
            this.ClientPasswordLogInTextBox.Click += new System.EventHandler(this.ClientPasswordTextBox_Click);
            // 
            // ClientUserNameLogInTextBox
            // 
            this.ClientUserNameLogInTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ClientUserNameLogInTextBox.Location = new System.Drawing.Point(134, 80);
            this.ClientUserNameLogInTextBox.Name = "ClientUserNameLogInTextBox";
            this.ClientUserNameLogInTextBox.Size = new System.Drawing.Size(145, 25);
            this.ClientUserNameLogInTextBox.TabIndex = 1;
            this.ClientUserNameLogInTextBox.Text = "Name";
            this.ClientUserNameLogInTextBox.Click += new System.EventHandler(this.ClientUserNameTextBox_Click);
            // 
            // passwordLogInClientLabel
            // 
            this.passwordLogInClientLabel.AutoSize = true;
            this.passwordLogInClientLabel.Location = new System.Drawing.Point(50, 126);
            this.passwordLogInClientLabel.Name = "passwordLogInClientLabel";
            this.passwordLogInClientLabel.Size = new System.Drawing.Size(63, 18);
            this.passwordLogInClientLabel.TabIndex = 0;
            this.passwordLogInClientLabel.Text = "Password";
            // 
            // usrnameLogInClientLabel
            // 
            this.usrnameLogInClientLabel.AutoSize = true;
            this.usrnameLogInClientLabel.Location = new System.Drawing.Point(50, 80);
            this.usrnameLogInClientLabel.Name = "usrnameLogInClientLabel";
            this.usrnameLogInClientLabel.Size = new System.Drawing.Size(73, 18);
            this.usrnameLogInClientLabel.TabIndex = 0;
            this.usrnameLogInClientLabel.Text = "User Name";
            // 
            // contractorLogInTabPage
            // 
            this.contractorLogInTabPage.Controls.Add(this.contractorLogInButton);
            this.contractorLogInTabPage.Controls.Add(this.ContractorPasswordLogInTextBox);
            this.contractorLogInTabPage.Controls.Add(this.ContractorEmployeeIDLogInTextBox);
            this.contractorLogInTabPage.Controls.Add(this.passwordLogInContractorLabel);
            this.contractorLogInTabPage.Controls.Add(this.employeeIDLogInContractorLabel);
            this.contractorLogInTabPage.Controls.Add(this.contractorLabel);
            this.contractorLogInTabPage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorLogInTabPage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.contractorLogInTabPage.Location = new System.Drawing.Point(4, 22);
            this.contractorLogInTabPage.Name = "contractorLogInTabPage";
            this.contractorLogInTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contractorLogInTabPage.Size = new System.Drawing.Size(313, 248);
            this.contractorLogInTabPage.TabIndex = 1;
            this.contractorLogInTabPage.Text = "Contractor";
            this.contractorLogInTabPage.UseVisualStyleBackColor = true;
            // 
            // contractorLogInButton
            // 
            this.contractorLogInButton.Location = new System.Drawing.Point(197, 175);
            this.contractorLogInButton.Name = "contractorLogInButton";
            this.contractorLogInButton.Size = new System.Drawing.Size(75, 28);
            this.contractorLogInButton.TabIndex = 72;
            this.contractorLogInButton.Text = "LogIn";
            this.contractorLogInButton.UseVisualStyleBackColor = true;
            this.contractorLogInButton.Click += new System.EventHandler(this.contractorLogInButton_Click);
            // 
            // ContractorPasswordLogInTextBox
            // 
            this.ContractorPasswordLogInTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorPasswordLogInTextBox.Location = new System.Drawing.Point(127, 132);
            this.ContractorPasswordLogInTextBox.Name = "ContractorPasswordLogInTextBox";
            this.ContractorPasswordLogInTextBox.Size = new System.Drawing.Size(145, 25);
            this.ContractorPasswordLogInTextBox.TabIndex = 70;
            this.ContractorPasswordLogInTextBox.Text = "Password";
            this.ContractorPasswordLogInTextBox.Click += new System.EventHandler(this.ContractorPasswordLogInTextBox_Click);
            // 
            // ContractorEmployeeIDLogInTextBox
            // 
            this.ContractorEmployeeIDLogInTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorEmployeeIDLogInTextBox.Location = new System.Drawing.Point(127, 86);
            this.ContractorEmployeeIDLogInTextBox.Name = "ContractorEmployeeIDLogInTextBox";
            this.ContractorEmployeeIDLogInTextBox.Size = new System.Drawing.Size(145, 25);
            this.ContractorEmployeeIDLogInTextBox.TabIndex = 71;
            this.ContractorEmployeeIDLogInTextBox.Text = "Employee ID";
            this.ContractorEmployeeIDLogInTextBox.Click += new System.EventHandler(this.ContractorEmployeeIDLogInTextBox_Click);
            // 
            // passwordLogInContractorLabel
            // 
            this.passwordLogInContractorLabel.AutoSize = true;
            this.passwordLogInContractorLabel.Location = new System.Drawing.Point(36, 132);
            this.passwordLogInContractorLabel.Name = "passwordLogInContractorLabel";
            this.passwordLogInContractorLabel.Size = new System.Drawing.Size(63, 18);
            this.passwordLogInContractorLabel.TabIndex = 68;
            this.passwordLogInContractorLabel.Text = "Password";
            // 
            // employeeIDLogInContractorLabel
            // 
            this.employeeIDLogInContractorLabel.AutoSize = true;
            this.employeeIDLogInContractorLabel.Location = new System.Drawing.Point(36, 86);
            this.employeeIDLogInContractorLabel.Name = "employeeIDLogInContractorLabel";
            this.employeeIDLogInContractorLabel.Size = new System.Drawing.Size(85, 18);
            this.employeeIDLogInContractorLabel.TabIndex = 69;
            this.employeeIDLogInContractorLabel.Text = "Employee ID";
            // 
            // contractorLabel
            // 
            this.contractorLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.contractorLabel.Location = new System.Drawing.Point(76, 32);
            this.contractorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contractorLabel.Name = "contractorLabel";
            this.contractorLabel.Size = new System.Drawing.Size(132, 23);
            this.contractorLabel.TabIndex = 67;
            this.contractorLabel.Text = "Contractor";
            this.contractorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitLogInLinkLabel
            // 
            this.exitLogInLinkLabel.AutoSize = true;
            this.exitLogInLinkLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLogInLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitLogInLinkLabel.Location = new System.Drawing.Point(12, 280);
            this.exitLogInLinkLabel.Name = "exitLogInLinkLabel";
            this.exitLogInLinkLabel.Size = new System.Drawing.Size(138, 22);
            this.exitLogInLinkLabel.TabIndex = 3;
            this.exitLogInLinkLabel.TabStop = true;
            this.exitLogInLinkLabel.Text = "Exit LogIn Screen";
            this.exitLogInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitLogInLinkLabel_LinkClicked);
            // 
            // LogIn_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 314);
            this.Controls.Add(this.exitLogInLinkLabel);
            this.Controls.Add(this.logInTabControl);
            this.Name = "LogIn_Page";
            this.Text = "LogIn_Page";
            this.logInTabControl.ResumeLayout(false);
            this.clientLogInTabPage.ResumeLayout(false);
            this.clientLogInTabPage.PerformLayout();
            this.contractorLogInTabPage.ResumeLayout(false);
            this.contractorLogInTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl logInTabControl;
        private System.Windows.Forms.TabPage clientLogInTabPage;
        private System.Windows.Forms.TabPage contractorLogInTabPage;
        private System.Windows.Forms.LinkLabel exitLogInLinkLabel;
        private System.Windows.Forms.TextBox ClientPasswordLogInTextBox;
        private System.Windows.Forms.TextBox ClientUserNameLogInTextBox;
        private System.Windows.Forms.Label passwordLogInClientLabel;
        private System.Windows.Forms.Label usrnameLogInClientLabel;
        internal System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Button clientLogInButton;
        private System.Windows.Forms.Button contractorLogInButton;
        private System.Windows.Forms.TextBox ContractorPasswordLogInTextBox;
        private System.Windows.Forms.TextBox ContractorEmployeeIDLogInTextBox;
        private System.Windows.Forms.Label passwordLogInContractorLabel;
        private System.Windows.Forms.Label employeeIDLogInContractorLabel;
        internal System.Windows.Forms.Label contractorLabel;
    }
}