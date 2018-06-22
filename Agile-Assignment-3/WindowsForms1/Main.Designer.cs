namespace WindowsForms1
{
    partial class Main
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
            this.IQIncorporatedlabel = new System.Windows.Forms.Label();
            this.clientButton = new System.Windows.Forms.Button();
            this.contractorButton = new System.Windows.Forms.Button();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.logInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // IQIncorporatedlabel
            // 
            this.IQIncorporatedlabel.AutoSize = true;
            this.IQIncorporatedlabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IQIncorporatedlabel.ForeColor = System.Drawing.Color.Aqua;
            this.IQIncorporatedlabel.Location = new System.Drawing.Point(97, 9);
            this.IQIncorporatedlabel.Name = "IQIncorporatedlabel";
            this.IQIncorporatedlabel.Size = new System.Drawing.Size(184, 33);
            this.IQIncorporatedlabel.TabIndex = 0;
            this.IQIncorporatedlabel.Text = "IQ Incorporated";
            // 
            // clientButton
            // 
            this.clientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clientButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.ForeColor = System.Drawing.Color.Red;
            this.clientButton.Location = new System.Drawing.Point(2, 240);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(163, 33);
            this.clientButton.TabIndex = 1;
            this.clientButton.Text = "Client";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // contractorButton
            // 
            this.contractorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contractorButton.FlatAppearance.BorderSize = 0;
            this.contractorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.contractorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.contractorButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorButton.ForeColor = System.Drawing.Color.Red;
            this.contractorButton.Location = new System.Drawing.Point(195, 240);
            this.contractorButton.Name = "contractorButton";
            this.contractorButton.Size = new System.Drawing.Size(163, 33);
            this.contractorButton.TabIndex = 2;
            this.contractorButton.Text = "Contractor";
            this.contractorButton.UseVisualStyleBackColor = true;
            this.contractorButton.Click += new System.EventHandler(this.contractorButton_Click);
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.signUpLinkLabel.Location = new System.Drawing.Point(133, 169);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(95, 33);
            this.signUpLinkLabel.TabIndex = 5;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "SignUp";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // logInLinkLabel
            // 
            this.logInLinkLabel.AutoSize = true;
            this.logInLinkLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.logInLinkLabel.Location = new System.Drawing.Point(133, 97);
            this.logInLinkLabel.Name = "logInLinkLabel";
            this.logInLinkLabel.Size = new System.Drawing.Size(80, 33);
            this.logInLinkLabel.TabIndex = 6;
            this.logInLinkLabel.TabStop = true;
            this.logInLinkLabel.Text = "LogIn";
            this.logInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInLinkLabel_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 323);
            this.Controls.Add(this.logInLinkLabel);
            this.Controls.Add(this.signUpLinkLabel);
            this.Controls.Add(this.contractorButton);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.IQIncorporatedlabel);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IQIncorporatedlabel;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Button contractorButton;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.LinkLabel logInLinkLabel;
    }
}

