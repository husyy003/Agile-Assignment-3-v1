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
            this.ClientPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ClientUserNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLogInClientLabel = new System.Windows.Forms.Label();
            this.usrnameLogInClientLabel = new System.Windows.Forms.Label();
            this.contractorLogInTabPage = new System.Windows.Forms.TabPage();
            this.contractorLogInButton = new System.Windows.Forms.Button();
            this.ContractorPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ContractorEmployeeIDTextBox = new System.Windows.Forms.TextBox();
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
            this.logInTabControl.Location = new System.Drawing.Point(8, 4);
            this.logInTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.logInTabControl.Name = "logInTabControl";
            this.logInTabControl.SelectedIndex = 0;
            this.logInTabControl.Size = new System.Drawing.Size(428, 337);
            this.logInTabControl.TabIndex = 0;
            // 
            // clientLogInTabPage
            // 
            this.clientLogInTabPage.Controls.Add(this.clientLogInButton);
            this.clientLogInTabPage.Controls.Add(this.clientLabel);
            this.clientLogInTabPage.Controls.Add(this.ClientPasswordTextBox);
            this.clientLogInTabPage.Controls.Add(this.ClientUserNameTextBox);
            this.clientLogInTabPage.Controls.Add(this.passwordLogInClientLabel);
            this.clientLogInTabPage.Controls.Add(this.usrnameLogInClientLabel);
            this.clientLogInTabPage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLogInTabPage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clientLogInTabPage.Location = new System.Drawing.Point(4, 25);
            this.clientLogInTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.clientLogInTabPage.Name = "clientLogInTabPage";
            this.clientLogInTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.clientLogInTabPage.Size = new System.Drawing.Size(420, 308);
            this.clientLogInTabPage.TabIndex = 0;
            this.clientLogInTabPage.Text = "Client";
            this.clientLogInTabPage.UseVisualStyleBackColor = true;
            // 
            // clientLogInButton
            // 
            this.clientLogInButton.Location = new System.Drawing.Point(272, 208);
            this.clientLogInButton.Margin = new System.Windows.Forms.Padding(4);
            this.clientLogInButton.Name = "clientLogInButton";
            this.clientLogInButton.Size = new System.Drawing.Size(100, 34);
            this.clientLogInButton.TabIndex = 67;
            this.clientLogInButton.Text = "LogIn";
            this.clientLogInButton.UseVisualStyleBackColor = true;
            this.clientLogInButton.Click += new System.EventHandler(this.clientLogInButton_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.clientLabel.Location = new System.Drawing.Point(101, 34);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(176, 28);
            this.clientLabel.TabIndex = 66;
            this.clientLabel.Text = "Client";
            this.clientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientPasswordTextBox
            // 
            this.ClientPasswordTextBox.Location = new System.Drawing.Point(179, 155);
            this.ClientPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientPasswordTextBox.Name = "ClientPasswordTextBox";
            this.ClientPasswordTextBox.Size = new System.Drawing.Size(192, 30);
            this.ClientPasswordTextBox.TabIndex = 1;
            // 
            // ClientUserNameTextBox
            // 
            this.ClientUserNameTextBox.Location = new System.Drawing.Point(179, 98);
            this.ClientUserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientUserNameTextBox.Name = "ClientUserNameTextBox";
            this.ClientUserNameTextBox.Size = new System.Drawing.Size(192, 30);
            this.ClientUserNameTextBox.TabIndex = 1;
            // 
            // passwordLogInClientLabel
            // 
            this.passwordLogInClientLabel.AutoSize = true;
            this.passwordLogInClientLabel.Location = new System.Drawing.Point(67, 155);
            this.passwordLogInClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLogInClientLabel.Name = "passwordLogInClientLabel";
            this.passwordLogInClientLabel.Size = new System.Drawing.Size(78, 24);
            this.passwordLogInClientLabel.TabIndex = 0;
            this.passwordLogInClientLabel.Text = "Password";
            // 
            // usrnameLogInClientLabel
            // 
            this.usrnameLogInClientLabel.AutoSize = true;
            this.usrnameLogInClientLabel.Location = new System.Drawing.Point(67, 98);
            this.usrnameLogInClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usrnameLogInClientLabel.Name = "usrnameLogInClientLabel";
            this.usrnameLogInClientLabel.Size = new System.Drawing.Size(89, 24);
            this.usrnameLogInClientLabel.TabIndex = 0;
            this.usrnameLogInClientLabel.Text = "User Name";
            // 
            // contractorLogInTabPage
            // 
            this.contractorLogInTabPage.Controls.Add(this.contractorLogInButton);
            this.contractorLogInTabPage.Controls.Add(this.ContractorPasswordTextBox);
            this.contractorLogInTabPage.Controls.Add(this.ContractorEmployeeIDTextBox);
            this.contractorLogInTabPage.Controls.Add(this.passwordLogInContractorLabel);
            this.contractorLogInTabPage.Controls.Add(this.employeeIDLogInContractorLabel);
            this.contractorLogInTabPage.Controls.Add(this.contractorLabel);
            this.contractorLogInTabPage.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorLogInTabPage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.contractorLogInTabPage.Location = new System.Drawing.Point(4, 25);
            this.contractorLogInTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.contractorLogInTabPage.Name = "contractorLogInTabPage";
            this.contractorLogInTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.contractorLogInTabPage.Size = new System.Drawing.Size(420, 308);
            this.contractorLogInTabPage.TabIndex = 1;
            this.contractorLogInTabPage.Text = "Contractor";
            this.contractorLogInTabPage.UseVisualStyleBackColor = true;
            // 
            // contractorLogInButton
            // 
            this.contractorLogInButton.Location = new System.Drawing.Point(263, 215);
            this.contractorLogInButton.Margin = new System.Windows.Forms.Padding(4);
            this.contractorLogInButton.Name = "contractorLogInButton";
            this.contractorLogInButton.Size = new System.Drawing.Size(100, 34);
            this.contractorLogInButton.TabIndex = 72;
            this.contractorLogInButton.Text = "LogIn";
            this.contractorLogInButton.UseVisualStyleBackColor = true;
            this.contractorLogInButton.Click += new System.EventHandler(this.contractorLogInButton_Click);
            // 
            // ContractorPasswordTextBox
            // 
            this.ContractorPasswordTextBox.Location = new System.Drawing.Point(169, 162);
            this.ContractorPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContractorPasswordTextBox.Name = "ContractorPasswordTextBox";
            this.ContractorPasswordTextBox.Size = new System.Drawing.Size(192, 30);
            this.ContractorPasswordTextBox.TabIndex = 70;
            // 
            // ContractorEmployeeIDTextBox
            // 
            this.ContractorEmployeeIDTextBox.Location = new System.Drawing.Point(169, 106);
            this.ContractorEmployeeIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContractorEmployeeIDTextBox.Name = "ContractorEmployeeIDTextBox";
            this.ContractorEmployeeIDTextBox.Size = new System.Drawing.Size(192, 30);
            this.ContractorEmployeeIDTextBox.TabIndex = 71;
            // 
            // passwordLogInContractorLabel
            // 
            this.passwordLogInContractorLabel.AutoSize = true;
            this.passwordLogInContractorLabel.Location = new System.Drawing.Point(48, 162);
            this.passwordLogInContractorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLogInContractorLabel.Name = "passwordLogInContractorLabel";
            this.passwordLogInContractorLabel.Size = new System.Drawing.Size(78, 24);
            this.passwordLogInContractorLabel.TabIndex = 68;
            this.passwordLogInContractorLabel.Text = "Password";
            // 
            // employeeIDLogInContractorLabel
            // 
            this.employeeIDLogInContractorLabel.AutoSize = true;
            this.employeeIDLogInContractorLabel.Location = new System.Drawing.Point(48, 106);
            this.employeeIDLogInContractorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeIDLogInContractorLabel.Name = "employeeIDLogInContractorLabel";
            this.employeeIDLogInContractorLabel.Size = new System.Drawing.Size(104, 24);
            this.employeeIDLogInContractorLabel.TabIndex = 69;
            this.employeeIDLogInContractorLabel.Text = "Employee ID";
            // 
            // contractorLabel
            // 
            this.contractorLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.contractorLabel.Location = new System.Drawing.Point(101, 39);
            this.contractorLabel.Name = "contractorLabel";
            this.contractorLabel.Size = new System.Drawing.Size(176, 28);
            this.contractorLabel.TabIndex = 67;
            this.contractorLabel.Text = "Contractor";
            this.contractorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitLogInLinkLabel
            // 
            this.exitLogInLinkLabel.AutoSize = true;
            this.exitLogInLinkLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLogInLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitLogInLinkLabel.Location = new System.Drawing.Point(16, 345);
            this.exitLogInLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitLogInLinkLabel.Name = "exitLogInLinkLabel";
            this.exitLogInLinkLabel.Size = new System.Drawing.Size(167, 28);
            this.exitLogInLinkLabel.TabIndex = 3;
            this.exitLogInLinkLabel.TabStop = true;
            this.exitLogInLinkLabel.Text = "Exit LogIn Screen";
            this.exitLogInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitLogInLinkLabel_LinkClicked);
            // 
            // LogIn_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 386);
            this.Controls.Add(this.exitLogInLinkLabel);
            this.Controls.Add(this.logInTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox ClientPasswordTextBox;
        private System.Windows.Forms.TextBox ClientUserNameTextBox;
        private System.Windows.Forms.Label passwordLogInClientLabel;
        private System.Windows.Forms.Label usrnameLogInClientLabel;
        internal System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Button clientLogInButton;
        private System.Windows.Forms.Button contractorLogInButton;
        private System.Windows.Forms.TextBox ContractorPasswordTextBox;
        private System.Windows.Forms.TextBox ContractorEmployeeIDTextBox;
        private System.Windows.Forms.Label passwordLogInContractorLabel;
        private System.Windows.Forms.Label employeeIDLogInContractorLabel;
        internal System.Windows.Forms.Label contractorLabel;
    }
}