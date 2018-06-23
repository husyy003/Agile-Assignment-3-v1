﻿namespace WindowsForms1
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.saveJobButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priorityBox = new System.Windows.Forms.TextBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.jobDiscriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.jobDiscriptionLabel = new System.Windows.Forms.Label();
            this.joblabel = new System.Windows.Forms.Label();
            this.jobButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.landLineNumberLabel = new System.Windows.Forms.Label();
            this.mobileNumberLabel = new System.Windows.Forms.Label();
            this.bussinessNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientBackButton = new System.Windows.Forms.Button();
            this.clientNameTextLabel = new System.Windows.Forms.Label();
            this.clientAddressTextLabel = new System.Windows.Forms.Label();
            this.clientLandLineNumberTextLabel = new System.Windows.Forms.Label();
            this.clientMobileNumberTextLabel = new System.Windows.Forms.Label();
            this.clientBussinessNameTextLabel = new System.Windows.Forms.Label();
            this.clientEmailTextLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.jobsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // saveJobButton
            // 
            this.saveJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saveJobButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.saveJobButton.Location = new System.Drawing.Point(381, 553);
            this.saveJobButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveJobButton.Name = "saveJobButton";
            this.saveJobButton.Size = new System.Drawing.Size(100, 36);
            this.saveJobButton.TabIndex = 51;
            this.saveJobButton.Text = "Save";
            this.saveJobButton.UseVisualStyleBackColor = false;
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(47, 506);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(136, 25);
            this.dateLabel.TabIndex = 50;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(207, 504);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(260, 22);
            this.dateTimePicker.TabIndex = 49;
            // 
            // priorityBox
            // 
            this.priorityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priorityBox.Location = new System.Drawing.Point(207, 472);
            this.priorityBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(261, 22);
            this.priorityBox.TabIndex = 48;
            this.priorityBox.TextChanged += new System.EventHandler(this.priorityBox_TextChanged);
            // 
            // priorityLabel
            // 
            this.priorityLabel.Location = new System.Drawing.Point(47, 472);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(127, 25);
            this.priorityLabel.TabIndex = 47;
            this.priorityLabel.Text = "Priority";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priorityLabel.Click += new System.EventHandler(this.priorityLabel_Click);
            // 
            // locationBox
            // 
            this.locationBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationBox.Location = new System.Drawing.Point(207, 426);
            this.locationBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.locationBox.Multiline = true;
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(261, 24);
            this.locationBox.TabIndex = 46;
            this.locationBox.TextChanged += new System.EventHandler(this.locationBox_TextChanged);
            // 
            // locationLabel
            // 
            this.locationLabel.Location = new System.Drawing.Point(47, 426);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(127, 25);
            this.locationLabel.TabIndex = 45;
            this.locationLabel.Text = "Location";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationLabel.Click += new System.EventHandler(this.locationLabel_Click);
            // 
            // jobDiscriptionRichTextBox
            // 
            this.jobDiscriptionRichTextBox.Location = new System.Drawing.Point(207, 341);
            this.jobDiscriptionRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.jobDiscriptionRichTextBox.Name = "jobDiscriptionRichTextBox";
            this.jobDiscriptionRichTextBox.Size = new System.Drawing.Size(260, 68);
            this.jobDiscriptionRichTextBox.TabIndex = 44;
            this.jobDiscriptionRichTextBox.Text = "";
            this.jobDiscriptionRichTextBox.TextChanged += new System.EventHandler(this.jobDiscriptionRichTextBox_TextChanged);
            // 
            // jobDiscriptionLabel
            // 
            this.jobDiscriptionLabel.Location = new System.Drawing.Point(47, 340);
            this.jobDiscriptionLabel.Name = "jobDiscriptionLabel";
            this.jobDiscriptionLabel.Size = new System.Drawing.Size(127, 25);
            this.jobDiscriptionLabel.TabIndex = 43;
            this.jobDiscriptionLabel.Text = "Job Discription";
            this.jobDiscriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jobDiscriptionLabel.Click += new System.EventHandler(this.jobDiscriptionLabel_Click);
            // 
            // joblabel
            // 
            this.joblabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joblabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.joblabel.Location = new System.Drawing.Point(94, 283);
            this.joblabel.Name = "joblabel";
            this.joblabel.Size = new System.Drawing.Size(275, 25);
            this.joblabel.TabIndex = 42;
            this.joblabel.Text = "Adding Job";
            this.joblabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.joblabel.Click += new System.EventHandler(this.joblabel_Click);
            // 
            // jobButton
            // 
            this.jobButton.Location = new System.Drawing.Point(294, 246);
            this.jobButton.Margin = new System.Windows.Forms.Padding(4);
            this.jobButton.Name = "jobButton";
            this.jobButton.Size = new System.Drawing.Size(111, 33);
            this.jobButton.TabIndex = 41;
            this.jobButton.Text = "Add Job";
            this.jobButton.UseVisualStyleBackColor = true;
            this.jobButton.Click += new System.EventHandler(this.jobButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(53, 206);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(90, 25);
            this.emailLabel.TabIndex = 39;
            this.emailLabel.Text = "Email";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // landLineNumberLabel
            // 
            this.landLineNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landLineNumberLabel.Location = new System.Drawing.Point(53, 131);
            this.landLineNumberLabel.Name = "landLineNumberLabel";
            this.landLineNumberLabel.Size = new System.Drawing.Size(144, 25);
            this.landLineNumberLabel.TabIndex = 37;
            this.landLineNumberLabel.Text = "Land Line Number";
            this.landLineNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mobileNumberLabel
            // 
            this.mobileNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNumberLabel.Location = new System.Drawing.Point(51, 156);
            this.mobileNumberLabel.Name = "mobileNumberLabel";
            this.mobileNumberLabel.Size = new System.Drawing.Size(135, 25);
            this.mobileNumberLabel.TabIndex = 35;
            this.mobileNumberLabel.Text = "Mobile Number";
            this.mobileNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bussinessNameLabel
            // 
            this.bussinessNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bussinessNameLabel.Location = new System.Drawing.Point(51, 181);
            this.bussinessNameLabel.Name = "bussinessNameLabel";
            this.bussinessNameLabel.Size = new System.Drawing.Size(135, 25);
            this.bussinessNameLabel.TabIndex = 33;
            this.bussinessNameLabel.Text = "Bussiness Name";
            this.bussinessNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(53, 82);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(92, 25);
            this.addressLabel.TabIndex = 31;
            this.addressLabel.Text = "Address";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.Location = new System.Drawing.Point(53, 55);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(133, 25);
            this.clientNameLabel.TabIndex = 29;
            this.clientNameLabel.Text = "Client Name";
            this.clientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientLabel
            // 
            this.clientLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.clientLabel.Location = new System.Drawing.Point(94, 9);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(176, 28);
            this.clientLabel.TabIndex = 52;
            this.clientLabel.Text = "Client";
            this.clientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(500, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 37);
            this.label1.TabIndex = 55;
            this.label1.Text = "All details should be added in database and field shouls show as job1, job2, job3" +
    " in this data grid view";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientBackButton
            // 
            this.clientBackButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientBackButton.Location = new System.Drawing.Point(10, 553);
            this.clientBackButton.Margin = new System.Windows.Forms.Padding(4);
            this.clientBackButton.Name = "clientBackButton";
            this.clientBackButton.Size = new System.Drawing.Size(100, 28);
            this.clientBackButton.TabIndex = 56;
            this.clientBackButton.Text = "Back";
            this.clientBackButton.UseVisualStyleBackColor = false;
            this.clientBackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clientNameTextLabel
            // 
            this.clientNameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameTextLabel.Location = new System.Drawing.Point(158, 55);
            this.clientNameTextLabel.Name = "clientNameTextLabel";
            this.clientNameTextLabel.Size = new System.Drawing.Size(323, 25);
            this.clientNameTextLabel.TabIndex = 58;
            this.clientNameTextLabel.Text = "----";
            this.clientNameTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientAddressTextLabel
            // 
            this.clientAddressTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientAddressTextLabel.Location = new System.Drawing.Point(158, 82);
            this.clientAddressTextLabel.Name = "clientAddressTextLabel";
            this.clientAddressTextLabel.Size = new System.Drawing.Size(125, 25);
            this.clientAddressTextLabel.TabIndex = 58;
            this.clientAddressTextLabel.Text = "----";
            this.clientAddressTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientLandLineNumberTextLabel
            // 
            this.clientLandLineNumberTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLandLineNumberTextLabel.Location = new System.Drawing.Point(203, 131);
            this.clientLandLineNumberTextLabel.Name = "clientLandLineNumberTextLabel";
            this.clientLandLineNumberTextLabel.Size = new System.Drawing.Size(125, 25);
            this.clientLandLineNumberTextLabel.TabIndex = 58;
            this.clientLandLineNumberTextLabel.Text = "----";
            this.clientLandLineNumberTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientMobileNumberTextLabel
            // 
            this.clientMobileNumberTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientMobileNumberTextLabel.Location = new System.Drawing.Point(203, 156);
            this.clientMobileNumberTextLabel.Name = "clientMobileNumberTextLabel";
            this.clientMobileNumberTextLabel.Size = new System.Drawing.Size(125, 25);
            this.clientMobileNumberTextLabel.TabIndex = 58;
            this.clientMobileNumberTextLabel.Text = "----";
            this.clientMobileNumberTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientBussinessNameTextLabel
            // 
            this.clientBussinessNameTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientBussinessNameTextLabel.Location = new System.Drawing.Point(203, 181);
            this.clientBussinessNameTextLabel.Name = "clientBussinessNameTextLabel";
            this.clientBussinessNameTextLabel.Size = new System.Drawing.Size(125, 25);
            this.clientBussinessNameTextLabel.TabIndex = 58;
            this.clientBussinessNameTextLabel.Text = "----";
            this.clientBussinessNameTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientEmailTextLabel
            // 
            this.clientEmailTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientEmailTextLabel.Location = new System.Drawing.Point(203, 206);
            this.clientEmailTextLabel.Name = "clientEmailTextLabel";
            this.clientEmailTextLabel.Size = new System.Drawing.Size(125, 25);
            this.clientEmailTextLabel.TabIndex = 58;
            this.clientEmailTextLabel.Text = "----";
            this.clientEmailTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(381, 622);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 33);
            this.searchButton.TabIndex = 59;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(10, 629);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(307, 22);
            this.searchTextBox.TabIndex = 60;
            
            // jobsDataGridView
            // 
            this.jobsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jobsDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.jobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsDataGridView.Location = new System.Drawing.Point(510, 96);
            this.jobsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.jobsDataGridView.Name = "jobsDataGridView";
            this.jobsDataGridView.Size = new System.Drawing.Size(473, 520);
            this.jobsDataGridView.TabIndex = 54;
            this.jobsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1019, 663);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clientEmailTextLabel);
            this.Controls.Add(this.clientBussinessNameTextLabel);
            this.Controls.Add(this.clientMobileNumberTextLabel);
            this.Controls.Add(this.clientLandLineNumberTextLabel);
            this.Controls.Add(this.clientAddressTextLabel);
            this.Controls.Add(this.clientNameTextLabel);
            this.Controls.Add(this.clientBackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobsDataGridView);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.saveJobButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.jobDiscriptionRichTextBox);
            this.Controls.Add(this.jobDiscriptionLabel);
            this.Controls.Add(this.joblabel);
            this.Controls.Add(this.jobButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.landLineNumberLabel);
            this.Controls.Add(this.mobileNumberLabel);
            this.Controls.Add(this.bussinessNameLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.clientNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
             ((System.ComponentModel.ISupportInitialize)(this.jobsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveJobButton;
        internal System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        internal System.Windows.Forms.TextBox priorityBox;
        internal System.Windows.Forms.Label priorityLabel;
        internal System.Windows.Forms.TextBox locationBox;
        internal System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.RichTextBox jobDiscriptionRichTextBox;
        internal System.Windows.Forms.Label jobDiscriptionLabel;
        internal System.Windows.Forms.Label joblabel;
        private System.Windows.Forms.Button jobButton;
        internal System.Windows.Forms.Label emailLabel;
        internal System.Windows.Forms.Label landLineNumberLabel;
        internal System.Windows.Forms.Label mobileNumberLabel;
        internal System.Windows.Forms.Label bussinessNameLabel;
        internal System.Windows.Forms.Label addressLabel;
        internal System.Windows.Forms.Label clientNameLabel;
        internal System.Windows.Forms.Label clientLabel;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clientBackButton;
        internal System.Windows.Forms.Label clientNameTextLabel;
        internal System.Windows.Forms.Label clientAddressTextLabel;
        internal System.Windows.Forms.Label clientLandLineNumberTextLabel;
        internal System.Windows.Forms.Label clientMobileNumberTextLabel;
        internal System.Windows.Forms.Label clientBussinessNameTextLabel;
        internal System.Windows.Forms.Label clientEmailTextLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource clientDataBindingSource;
        
        private System.Windows.Forms.DataGridView jobsDataGridView;
    }
}