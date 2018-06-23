namespace WindowsForms1
{
    partial class SignUp
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.signUpClientTab = new System.Windows.Forms.TabPage();
            this.ClientPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createClientBtn = new System.Windows.Forms.Button();
            this.ClientAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.clientLabel = new System.Windows.Forms.Label();
            this.ClientEmailTextBox = new System.Windows.Forms.TextBox();
            this.ClientLandLineNumberTextBox = new System.Windows.Forms.TextBox();
            this.ClientMobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.ClientBusinessNameTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.signUpContractorTab = new System.Windows.Forms.TabPage();
            this.ContractorPasswordTextBox = new System.Windows.Forms.TextBox();
            this.createContractorBtn = new System.Windows.Forms.Button();
            this.ContractorEmailTextBox = new System.Windows.Forms.TextBox();
            this.ContractorOccupationTextBox = new System.Windows.Forms.TextBox();
            this.ContractorLandLineNumberTextBox = new System.Windows.Forms.TextBox();
            this.ContractorMobileNumberTextBox = new System.Windows.Forms.TextBox();
            this.ContractorAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.contractorLabel = new System.Windows.Forms.Label();
            this.ContractorEmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.ContractorNameTextBox = new System.Windows.Forms.TextBox();
            this.exitSignUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl.SuspendLayout();
            this.signUpClientTab.SuspendLayout();
            this.signUpContractorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.signUpClientTab);
            this.tabControl.Controls.Add(this.signUpContractorTab);
            this.tabControl.Location = new System.Drawing.Point(1, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(293, 417);
            this.tabControl.TabIndex = 0;
            // 
            // signUpClientTab
            // 
            this.signUpClientTab.BackColor = System.Drawing.Color.Azure;
            this.signUpClientTab.Controls.Add(this.ClientPasswordTextBox);
            this.signUpClientTab.Controls.Add(this.createClientBtn);
            this.signUpClientTab.Controls.Add(this.ClientAddressTextBox);
            this.signUpClientTab.Controls.Add(this.clientLabel);
            this.signUpClientTab.Controls.Add(this.ClientEmailTextBox);
            this.signUpClientTab.Controls.Add(this.ClientLandLineNumberTextBox);
            this.signUpClientTab.Controls.Add(this.ClientMobileNumberTextBox);
            this.signUpClientTab.Controls.Add(this.ClientBusinessNameTextBox);
            this.signUpClientTab.Controls.Add(this.clientNameTextBox);
            this.signUpClientTab.Location = new System.Drawing.Point(4, 22);
            this.signUpClientTab.Name = "signUpClientTab";
            this.signUpClientTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.signUpClientTab.Size = new System.Drawing.Size(285, 391);
            this.signUpClientTab.TabIndex = 0;
            this.signUpClientTab.Text = "Client";
            // 
            // ClientPasswordTextBox
            // 
            this.ClientPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPasswordTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ClientPasswordTextBox.Location = new System.Drawing.Point(25, 89);
            this.ClientPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientPasswordTextBox.Name = "ClientPasswordTextBox";
            this.ClientPasswordTextBox.Size = new System.Drawing.Size(222, 20);
            this.ClientPasswordTextBox.TabIndex = 70;
            this.ClientPasswordTextBox.Text = "Password";
            this.ClientPasswordTextBox.Click += new System.EventHandler(this.ClientPasswordTextBox_Click);
            // 
            // createClientBtn
            // 
            this.createClientBtn.Location = new System.Drawing.Point(191, 360);
            this.createClientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createClientBtn.Name = "createClientBtn";
            this.createClientBtn.Size = new System.Drawing.Size(56, 19);
            this.createClientBtn.TabIndex = 69;
            this.createClientBtn.Text = "Create";
            this.createClientBtn.UseVisualStyleBackColor = true;
            this.createClientBtn.Click += new System.EventHandler(this.createClientBtn_Click);
            // 
            // ClientAddressTextBox
            // 
            this.ClientAddressTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ClientAddressTextBox.Location = new System.Drawing.Point(23, 132);
            this.ClientAddressTextBox.Name = "ClientAddressTextBox";
            this.ClientAddressTextBox.Size = new System.Drawing.Size(224, 69);
            this.ClientAddressTextBox.TabIndex = 66;
            this.ClientAddressTextBox.Text = "Address";
            this.ClientAddressTextBox.Click += new System.EventHandler(this.ClientAddressTextBox_Click);
            // 
            // clientLabel
            // 
            this.clientLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.clientLabel.Location = new System.Drawing.Point(74, 19);
            this.clientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(132, 23);
            this.clientLabel.TabIndex = 65;
            this.clientLabel.Text = "Client";
            this.clientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientEmailTextBox
            // 
            this.ClientEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientEmailTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ClientEmailTextBox.Location = new System.Drawing.Point(25, 322);
            this.ClientEmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientEmailTextBox.Name = "ClientEmailTextBox";
            this.ClientEmailTextBox.Size = new System.Drawing.Size(222, 20);
            this.ClientEmailTextBox.TabIndex = 64;
            this.ClientEmailTextBox.Text = "Email Address";
            this.ClientEmailTextBox.Click += new System.EventHandler(this.ClientEmailTextBox_Click);
            // 
            // ClientLandLineNumberTextBox
            // 
            this.ClientLandLineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientLandLineNumberTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ClientLandLineNumberTextBox.Location = new System.Drawing.Point(25, 220);
            this.ClientLandLineNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientLandLineNumberTextBox.Name = "ClientLandLineNumberTextBox";
            this.ClientLandLineNumberTextBox.Size = new System.Drawing.Size(222, 20);
            this.ClientLandLineNumberTextBox.TabIndex = 62;
            this.ClientLandLineNumberTextBox.Text = "Landline Number";
            this.ClientLandLineNumberTextBox.Click += new System.EventHandler(this.ClientLandLineNumberTextBox_Click);
            // 
            // ClientMobileNumberTextBox
            // 
            this.ClientMobileNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientMobileNumberTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ClientMobileNumberTextBox.Location = new System.Drawing.Point(25, 253);
            this.ClientMobileNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientMobileNumberTextBox.Name = "ClientMobileNumberTextBox";
            this.ClientMobileNumberTextBox.Size = new System.Drawing.Size(222, 20);
            this.ClientMobileNumberTextBox.TabIndex = 60;
            this.ClientMobileNumberTextBox.Text = "Mobile Number";
            this.ClientMobileNumberTextBox.Click += new System.EventHandler(this.ClientMobileNumberTextBox_Click);
            // 
            // ClientBusinessNameTextBox
            // 
            this.ClientBusinessNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientBusinessNameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ClientBusinessNameTextBox.Location = new System.Drawing.Point(25, 287);
            this.ClientBusinessNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClientBusinessNameTextBox.Name = "ClientBusinessNameTextBox";
            this.ClientBusinessNameTextBox.Size = new System.Drawing.Size(222, 20);
            this.ClientBusinessNameTextBox.TabIndex = 58;
            this.ClientBusinessNameTextBox.Text = "Bussiness Name";
            this.ClientBusinessNameTextBox.Click += new System.EventHandler(this.ClientBusinessNameTextBox_Click);
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientNameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.clientNameTextBox.Location = new System.Drawing.Point(23, 55);
            this.clientNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.clientNameTextBox.TabIndex = 55;
            this.clientNameTextBox.Text = "Name";
            this.clientNameTextBox.Click += new System.EventHandler(this.clientNameTextBox_Click);
            // 
            // signUpContractorTab
            // 
            this.signUpContractorTab.Controls.Add(this.ContractorPasswordTextBox);
            this.signUpContractorTab.Controls.Add(this.createContractorBtn);
            this.signUpContractorTab.Controls.Add(this.ContractorEmailTextBox);
            this.signUpContractorTab.Controls.Add(this.ContractorOccupationTextBox);
            this.signUpContractorTab.Controls.Add(this.ContractorLandLineNumberTextBox);
            this.signUpContractorTab.Controls.Add(this.ContractorMobileNumberTextBox);
            this.signUpContractorTab.Controls.Add(this.ContractorAddressTextBox);
            this.signUpContractorTab.Controls.Add(this.contractorLabel);
            this.signUpContractorTab.Controls.Add(this.ContractorEmployeeIDTextBox);
            this.signUpContractorTab.Controls.Add(this.ContractorNameTextBox);
            this.signUpContractorTab.Location = new System.Drawing.Point(4, 22);
            this.signUpContractorTab.Name = "signUpContractorTab";
            this.signUpContractorTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.signUpContractorTab.Size = new System.Drawing.Size(285, 391);
            this.signUpContractorTab.TabIndex = 1;
            this.signUpContractorTab.Text = "Contractor";
            this.signUpContractorTab.UseVisualStyleBackColor = true;
            // 
            // ContractorPasswordTextBox
            // 
            this.ContractorPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContractorPasswordTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorPasswordTextBox.Location = new System.Drawing.Point(26, 105);
            this.ContractorPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractorPasswordTextBox.Name = "ContractorPasswordTextBox";
            this.ContractorPasswordTextBox.Size = new System.Drawing.Size(233, 20);
            this.ContractorPasswordTextBox.TabIndex = 80;
            this.ContractorPasswordTextBox.Text = "Password";
            this.ContractorPasswordTextBox.Click += new System.EventHandler(this.ContractorPasswordTextBox_Click);
            // 
            // createContractorBtn
            // 
            this.createContractorBtn.Location = new System.Drawing.Point(201, 356);
            this.createContractorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createContractorBtn.Name = "createContractorBtn";
            this.createContractorBtn.Size = new System.Drawing.Size(56, 19);
            this.createContractorBtn.TabIndex = 79;
            this.createContractorBtn.Text = "Create";
            this.createContractorBtn.UseVisualStyleBackColor = true;
            this.createContractorBtn.Click += new System.EventHandler(this.createContractorBtn_Click);
            // 
            // ContractorEmailTextBox
            // 
            this.ContractorEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractorEmailTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorEmailTextBox.Location = new System.Drawing.Point(24, 323);
            this.ContractorEmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractorEmailTextBox.Name = "ContractorEmailTextBox";
            this.ContractorEmailTextBox.Size = new System.Drawing.Size(233, 20);
            this.ContractorEmailTextBox.TabIndex = 78;
            this.ContractorEmailTextBox.Text = "Email Address";
            this.ContractorEmailTextBox.Click += new System.EventHandler(this.ContractorEmailTextBox_Click);
            // 
            // ContractorOccupationTextBox
            // 
            this.ContractorOccupationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContractorOccupationTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorOccupationTextBox.Location = new System.Drawing.Point(26, 134);
            this.ContractorOccupationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractorOccupationTextBox.Name = "ContractorOccupationTextBox";
            this.ContractorOccupationTextBox.Size = new System.Drawing.Size(233, 20);
            this.ContractorOccupationTextBox.TabIndex = 75;
            this.ContractorOccupationTextBox.Text = "Occupation";
            this.ContractorOccupationTextBox.Click += new System.EventHandler(this.ContractorOccupationTextBox_Click);
            // 
            // ContractorLandLineNumberTextBox
            // 
            this.ContractorLandLineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractorLandLineNumberTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorLandLineNumberTextBox.Location = new System.Drawing.Point(24, 255);
            this.ContractorLandLineNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractorLandLineNumberTextBox.Name = "ContractorLandLineNumberTextBox";
            this.ContractorLandLineNumberTextBox.Size = new System.Drawing.Size(233, 20);
            this.ContractorLandLineNumberTextBox.TabIndex = 73;
            this.ContractorLandLineNumberTextBox.Text = "Land Line Number";
            this.ContractorLandLineNumberTextBox.Click += new System.EventHandler(this.ContractorLandLineNumberTextBox_Click);
            // 
            // ContractorMobileNumberTextBox
            // 
            this.ContractorMobileNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractorMobileNumberTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorMobileNumberTextBox.Location = new System.Drawing.Point(24, 289);
            this.ContractorMobileNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractorMobileNumberTextBox.Name = "ContractorMobileNumberTextBox";
            this.ContractorMobileNumberTextBox.Size = new System.Drawing.Size(233, 20);
            this.ContractorMobileNumberTextBox.TabIndex = 71;
            this.ContractorMobileNumberTextBox.Text = "Mobile Number";
            this.ContractorMobileNumberTextBox.Click += new System.EventHandler(this.ContractorMobileNumberTextBox_Click);
            // 
            // ContractorAddressTextBox
            // 
            this.ContractorAddressTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorAddressTextBox.Location = new System.Drawing.Point(24, 170);
            this.ContractorAddressTextBox.Name = "ContractorAddressTextBox";
            this.ContractorAddressTextBox.Size = new System.Drawing.Size(233, 63);
            this.ContractorAddressTextBox.TabIndex = 69;
            this.ContractorAddressTextBox.Text = "Address";
            this.ContractorAddressTextBox.Click += new System.EventHandler(this.ContractorAddressTextBox_Click);
            // 
            // contractorLabel
            // 
            this.contractorLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.contractorLabel.Location = new System.Drawing.Point(79, 13);
            this.contractorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contractorLabel.Name = "contractorLabel";
            this.contractorLabel.Size = new System.Drawing.Size(132, 23);
            this.contractorLabel.TabIndex = 66;
            this.contractorLabel.Text = "Contractor";
            this.contractorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContractorEmployeeIDTextBox
            // 
            this.ContractorEmployeeIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContractorEmployeeIDTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorEmployeeIDTextBox.Location = new System.Drawing.Point(26, 76);
            this.ContractorEmployeeIDTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractorEmployeeIDTextBox.Name = "ContractorEmployeeIDTextBox";
            this.ContractorEmployeeIDTextBox.Size = new System.Drawing.Size(233, 20);
            this.ContractorEmployeeIDTextBox.TabIndex = 34;
            this.ContractorEmployeeIDTextBox.Text = "Employee ID";
            this.ContractorEmployeeIDTextBox.Click += new System.EventHandler(this.ContractorEmployeeIDTextBox_Click);
            // 
            // ContractorNameTextBox
            // 
            this.ContractorNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContractorNameTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ContractorNameTextBox.Location = new System.Drawing.Point(26, 45);
            this.ContractorNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractorNameTextBox.Name = "ContractorNameTextBox";
            this.ContractorNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.ContractorNameTextBox.TabIndex = 30;
            this.ContractorNameTextBox.Text = "Name";
            this.ContractorNameTextBox.Click += new System.EventHandler(this.ContractorNameTextBox_Click);
            // 
            // exitSignUpLinkLabel
            // 
            this.exitSignUpLinkLabel.AutoSize = true;
            this.exitSignUpLinkLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitSignUpLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitSignUpLinkLabel.Location = new System.Drawing.Point(12, 436);
            this.exitSignUpLinkLabel.Name = "exitSignUpLinkLabel";
            this.exitSignUpLinkLabel.Size = new System.Drawing.Size(99, 22);
            this.exitSignUpLinkLabel.TabIndex = 2;
            this.exitSignUpLinkLabel.TabStop = true;
            this.exitSignUpLinkLabel.Text = "Exit SignUp";
            this.exitSignUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 472);
            this.Controls.Add(this.exitSignUpLinkLabel);
            this.Controls.Add(this.tabControl);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.tabControl.ResumeLayout(false);
            this.signUpClientTab.ResumeLayout(false);
            this.signUpClientTab.PerformLayout();
            this.signUpContractorTab.ResumeLayout(false);
            this.signUpContractorTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage signUpClientTab;
        private System.Windows.Forms.TabPage signUpContractorTab;
        private System.Windows.Forms.RichTextBox ClientAddressTextBox;
        internal System.Windows.Forms.Label clientLabel;
        internal System.Windows.Forms.TextBox ClientEmailTextBox;
        internal System.Windows.Forms.TextBox ClientBusinessNameTextBox;
        internal System.Windows.Forms.TextBox clientNameTextBox;
        internal System.Windows.Forms.Label contractorLabel;
        internal System.Windows.Forms.TextBox ContractorEmployeeIDTextBox;
        internal System.Windows.Forms.TextBox ContractorNameTextBox;
        internal System.Windows.Forms.TextBox ClientLandLineNumberTextBox;
        internal System.Windows.Forms.TextBox ClientMobileNumberTextBox;
        internal System.Windows.Forms.TextBox ContractorEmailTextBox;
        internal System.Windows.Forms.TextBox ContractorOccupationTextBox;
        internal System.Windows.Forms.TextBox ContractorLandLineNumberTextBox;
        internal System.Windows.Forms.TextBox ContractorMobileNumberTextBox;
        private System.Windows.Forms.RichTextBox ContractorAddressTextBox;
        private System.Windows.Forms.LinkLabel exitSignUpLinkLabel;
        private System.Windows.Forms.Button createClientBtn;
        private System.Windows.Forms.Button createContractorBtn;
        internal System.Windows.Forms.TextBox ContractorPasswordTextBox;
        internal System.Windows.Forms.TextBox ClientPasswordTextBox;
    }
}