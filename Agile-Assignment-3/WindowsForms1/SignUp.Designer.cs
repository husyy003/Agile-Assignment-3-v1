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
            this.tabControl.Location = new System.Drawing.Point(1, 5);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(420, 513);
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
            this.signUpClientTab.Location = new System.Drawing.Point(4, 25);
            this.signUpClientTab.Margin = new System.Windows.Forms.Padding(4);
            this.signUpClientTab.Name = "signUpClientTab";
            this.signUpClientTab.Padding = new System.Windows.Forms.Padding(4);
            this.signUpClientTab.Size = new System.Drawing.Size(412, 484);
            this.signUpClientTab.TabIndex = 0;
            this.signUpClientTab.Text = "Client";
            // 
            // ClientPasswordTextBox
            // 
            this.ClientPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPasswordTextBox.Location = new System.Drawing.Point(61, 118);
            this.ClientPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientPasswordTextBox.Name = "ClientPasswordTextBox";
            this.ClientPasswordTextBox.Size = new System.Drawing.Size(265, 22);
            this.ClientPasswordTextBox.TabIndex = 70;
            this.ClientPasswordTextBox.Text = "Password";
            // 
            // createClientBtn
            // 
            this.createClientBtn.Location = new System.Drawing.Point(320, 439);
            this.createClientBtn.Name = "createClientBtn";
            this.createClientBtn.Size = new System.Drawing.Size(75, 23);
            this.createClientBtn.TabIndex = 69;
            this.createClientBtn.Text = "Create";
            this.createClientBtn.UseVisualStyleBackColor = true;
            this.createClientBtn.Click += new System.EventHandler(this.createClientBtn_Click);
            // 
            // ClientAddressTextBox
            // 
            this.ClientAddressTextBox.Location = new System.Drawing.Point(58, 171);
            this.ClientAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClientAddressTextBox.Name = "ClientAddressTextBox";
            this.ClientAddressTextBox.Size = new System.Drawing.Size(267, 84);
            this.ClientAddressTextBox.TabIndex = 66;
            this.ClientAddressTextBox.Text = "Address";
            // 
            // clientLabel
            // 
            this.clientLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.clientLabel.Location = new System.Drawing.Point(98, 23);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(176, 28);
            this.clientLabel.TabIndex = 65;
            this.clientLabel.Text = "Client";
            this.clientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientEmailTextBox
            // 
            this.ClientEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientEmailTextBox.Location = new System.Drawing.Point(61, 405);
            this.ClientEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientEmailTextBox.Name = "ClientEmailTextBox";
            this.ClientEmailTextBox.Size = new System.Drawing.Size(265, 22);
            this.ClientEmailTextBox.TabIndex = 64;
            this.ClientEmailTextBox.Text = "Email Address";
            // 
            // ClientLandLineNumberTextBox
            // 
            this.ClientLandLineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientLandLineNumberTextBox.Location = new System.Drawing.Point(61, 279);
            this.ClientLandLineNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientLandLineNumberTextBox.Name = "ClientLandLineNumberTextBox";
            this.ClientLandLineNumberTextBox.Size = new System.Drawing.Size(265, 22);
            this.ClientLandLineNumberTextBox.TabIndex = 62;
            this.ClientLandLineNumberTextBox.Text = "Landline Number";
            // 
            // ClientMobileNumberTextBox
            // 
            this.ClientMobileNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientMobileNumberTextBox.Location = new System.Drawing.Point(61, 320);
            this.ClientMobileNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientMobileNumberTextBox.Name = "ClientMobileNumberTextBox";
            this.ClientMobileNumberTextBox.Size = new System.Drawing.Size(265, 22);
            this.ClientMobileNumberTextBox.TabIndex = 60;
            this.ClientMobileNumberTextBox.Text = "Mobile Number";
            // 
            // ClientBusinessNameTextBox
            // 
            this.ClientBusinessNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientBusinessNameTextBox.Location = new System.Drawing.Point(61, 362);
            this.ClientBusinessNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientBusinessNameTextBox.Name = "ClientBusinessNameTextBox";
            this.ClientBusinessNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.ClientBusinessNameTextBox.TabIndex = 58;
            this.ClientBusinessNameTextBox.Text = "Bussiness Name";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientNameTextBox.Location = new System.Drawing.Point(58, 76);
            this.clientNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(265, 22);
            this.clientNameTextBox.TabIndex = 55;
            this.clientNameTextBox.Text = "Name";
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
            this.signUpContractorTab.Location = new System.Drawing.Point(4, 25);
            this.signUpContractorTab.Margin = new System.Windows.Forms.Padding(4);
            this.signUpContractorTab.Name = "signUpContractorTab";
            this.signUpContractorTab.Padding = new System.Windows.Forms.Padding(4);
            this.signUpContractorTab.Size = new System.Drawing.Size(412, 484);
            this.signUpContractorTab.TabIndex = 1;
            this.signUpContractorTab.Text = "Contractor";
            this.signUpContractorTab.UseVisualStyleBackColor = true;
            // 
            // ContractorPasswordTextBox
            // 
            this.ContractorPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContractorPasswordTextBox.Location = new System.Drawing.Point(59, 145);
            this.ContractorPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContractorPasswordTextBox.Name = "ContractorPasswordTextBox";
            this.ContractorPasswordTextBox.Size = new System.Drawing.Size(309, 22);
            this.ContractorPasswordTextBox.TabIndex = 80;
            this.ContractorPasswordTextBox.Text = "Password";
            // 
            // createContractorBtn
            // 
            this.createContractorBtn.Location = new System.Drawing.Point(319, 455);
            this.createContractorBtn.Name = "createContractorBtn";
            this.createContractorBtn.Size = new System.Drawing.Size(75, 23);
            this.createContractorBtn.TabIndex = 79;
            this.createContractorBtn.Text = "Create";
            this.createContractorBtn.UseVisualStyleBackColor = true;
            this.createContractorBtn.Click += new System.EventHandler(this.createContractorBtn_Click);
            // 
            // ContractorEmailTextBox
            // 
            this.ContractorEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractorEmailTextBox.Location = new System.Drawing.Point(58, 428);
            this.ContractorEmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContractorEmailTextBox.Name = "ContractorEmailTextBox";
            this.ContractorEmailTextBox.Size = new System.Drawing.Size(310, 22);
            this.ContractorEmailTextBox.TabIndex = 78;
            this.ContractorEmailTextBox.Text = "Email Address";
            // 
            // ContractorOccupationTextBox
            // 
            this.ContractorOccupationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContractorOccupationTextBox.Location = new System.Drawing.Point(58, 181);
            this.ContractorOccupationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContractorOccupationTextBox.Name = "ContractorOccupationTextBox";
            this.ContractorOccupationTextBox.Size = new System.Drawing.Size(309, 22);
            this.ContractorOccupationTextBox.TabIndex = 75;
            this.ContractorOccupationTextBox.Text = "Occupation";
            // 
            // ContractorLandLineNumberTextBox
            // 
            this.ContractorLandLineNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractorLandLineNumberTextBox.Location = new System.Drawing.Point(58, 345);
            this.ContractorLandLineNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContractorLandLineNumberTextBox.Name = "ContractorLandLineNumberTextBox";
            this.ContractorLandLineNumberTextBox.Size = new System.Drawing.Size(310, 22);
            this.ContractorLandLineNumberTextBox.TabIndex = 73;
            this.ContractorLandLineNumberTextBox.Text = "Land Line Number";
            // 
            // ContractorMobileNumberTextBox
            // 
            this.ContractorMobileNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContractorMobileNumberTextBox.Location = new System.Drawing.Point(58, 386);
            this.ContractorMobileNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContractorMobileNumberTextBox.Name = "ContractorMobileNumberTextBox";
            this.ContractorMobileNumberTextBox.Size = new System.Drawing.Size(310, 22);
            this.ContractorMobileNumberTextBox.TabIndex = 71;
            this.ContractorMobileNumberTextBox.Text = "Mobile Number";
            // 
            // ContractorAddressTextBox
            // 
            this.ContractorAddressTextBox.Location = new System.Drawing.Point(58, 224);
            this.ContractorAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContractorAddressTextBox.Name = "ContractorAddressTextBox";
            this.ContractorAddressTextBox.Size = new System.Drawing.Size(309, 77);
            this.ContractorAddressTextBox.TabIndex = 69;
            this.ContractorAddressTextBox.Text = "Address";
            // 
            // contractorLabel
            // 
            this.contractorLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.contractorLabel.Location = new System.Drawing.Point(97, 28);
            this.contractorLabel.Name = "contractorLabel";
            this.contractorLabel.Size = new System.Drawing.Size(176, 28);
            this.contractorLabel.TabIndex = 66;
            this.contractorLabel.Text = "Contractor";
            this.contractorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContractorEmployeeIDTextBox
            // 
            this.ContractorEmployeeIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContractorEmployeeIDTextBox.Location = new System.Drawing.Point(58, 109);
            this.ContractorEmployeeIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContractorEmployeeIDTextBox.Name = "ContractorEmployeeIDTextBox";
            this.ContractorEmployeeIDTextBox.Size = new System.Drawing.Size(309, 22);
            this.ContractorEmployeeIDTextBox.TabIndex = 34;
            this.ContractorEmployeeIDTextBox.Text = "Employee ID";
            // 
            // ContractorNameTextBox
            // 
            this.ContractorNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ContractorNameTextBox.Location = new System.Drawing.Point(58, 72);
            this.ContractorNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContractorNameTextBox.Name = "ContractorNameTextBox";
            this.ContractorNameTextBox.Size = new System.Drawing.Size(309, 22);
            this.ContractorNameTextBox.TabIndex = 30;
            this.ContractorNameTextBox.Text = "Name";
            // 
            // exitSignUpLinkLabel
            // 
            this.exitSignUpLinkLabel.AutoSize = true;
            this.exitSignUpLinkLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitSignUpLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitSignUpLinkLabel.Location = new System.Drawing.Point(16, 537);
            this.exitSignUpLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitSignUpLinkLabel.Name = "exitSignUpLinkLabel";
            this.exitSignUpLinkLabel.Size = new System.Drawing.Size(122, 28);
            this.exitSignUpLinkLabel.TabIndex = 2;
            this.exitSignUpLinkLabel.TabStop = true;
            this.exitSignUpLinkLabel.Text = "Exit SignUp";
            this.exitSignUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 581);
            this.Controls.Add(this.exitSignUpLinkLabel);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
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