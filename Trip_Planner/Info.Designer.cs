namespace Trip_Planner
{
    partial class Info
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
            this.gbPreferences = new System.Windows.Forms.GroupBox();
            this.clbpreferences = new System.Windows.Forms.CheckedListBox();
            this.gbTrip = new System.Windows.Forms.GroupBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.datetimeTrip = new System.Windows.Forms.DateTimePicker();
            this.gbPersonal = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.richtxt1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.gbPreferences.SuspendLayout();
            this.gbTrip.SuspendLayout();
            this.gbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPreferences
            // 
            this.gbPreferences.Controls.Add(this.richTextBox2);
            this.gbPreferences.Controls.Add(this.clbpreferences);
            this.gbPreferences.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreferences.ForeColor = System.Drawing.Color.Navy;
            this.gbPreferences.Location = new System.Drawing.Point(34, 579);
            this.gbPreferences.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPreferences.Name = "gbPreferences";
            this.gbPreferences.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPreferences.Size = new System.Drawing.Size(568, 272);
            this.gbPreferences.TabIndex = 12;
            this.gbPreferences.TabStop = false;
            this.gbPreferences.Text = "Preferences";
            // 
            // clbpreferences
            // 
            this.clbpreferences.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clbpreferences.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbpreferences.ForeColor = System.Drawing.Color.Black;
            this.clbpreferences.FormattingEnabled = true;
            this.clbpreferences.Items.AddRange(new object[] {
            "Hiking",
            "Swimming",
            "SightSeeing",
            "Relaxation"});
            this.clbpreferences.Location = new System.Drawing.Point(18, 101);
            this.clbpreferences.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbpreferences.Name = "clbpreferences";
            this.clbpreferences.Size = new System.Drawing.Size(466, 140);
            this.clbpreferences.TabIndex = 8;
            this.clbpreferences.SelectedIndexChanged += new System.EventHandler(this.clbInterests_SelectedIndexChanged);
            // 
            // gbTrip
            // 
            this.gbTrip.Controls.Add(this.lblReason);
            this.gbTrip.Controls.Add(this.txtReason);
            this.gbTrip.Controls.Add(this.lblDate);
            this.gbTrip.Controls.Add(this.datetimeTrip);
            this.gbTrip.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold);
            this.gbTrip.ForeColor = System.Drawing.Color.Navy;
            this.gbTrip.Location = new System.Drawing.Point(684, 162);
            this.gbTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTrip.Name = "gbTrip";
            this.gbTrip.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTrip.Size = new System.Drawing.Size(556, 472);
            this.gbTrip.TabIndex = 11;
            this.gbTrip.TabStop = false;
            this.gbTrip.Text = "Trip Info";
            this.gbTrip.Enter += new System.EventHandler(this.gbTrip_Enter);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.ForeColor = System.Drawing.Color.Black;
            this.lblReason.Location = new System.Drawing.Point(22, 203);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(428, 23);
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "Why do you want to visit Jordan? (Optional)";
            // 
            // txtReason
            // 
            this.txtReason.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReason.Location = new System.Drawing.Point(26, 258);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReason.Size = new System.Drawing.Size(280, 159);
            this.txtReason.TabIndex = 2;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(22, 58);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(156, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date and Time ";
            // 
            // datetimeTrip
            // 
            this.datetimeTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeTrip.Location = new System.Drawing.Point(26, 109);
            this.datetimeTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datetimeTrip.Name = "datetimeTrip";
            this.datetimeTrip.Size = new System.Drawing.Size(298, 26);
            this.datetimeTrip.TabIndex = 0;
            // 
            // gbPersonal
            // 
            this.gbPersonal.Controls.Add(this.rdbFemale);
            this.gbPersonal.Controls.Add(this.rdbMale);
            this.gbPersonal.Controls.Add(this.label1);
            this.gbPersonal.Controls.Add(this.txtNumber);
            this.gbPersonal.Controls.Add(this.lblNumber);
            this.gbPersonal.Controls.Add(this.lblName);
            this.gbPersonal.Controls.Add(this.txtEmail);
            this.gbPersonal.Controls.Add(this.lblEmail);
            this.gbPersonal.Controls.Add(this.txtName);
            this.gbPersonal.Controls.Add(this.lblAge);
            this.gbPersonal.Controls.Add(this.nudAge);
            this.gbPersonal.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPersonal.ForeColor = System.Drawing.Color.Navy;
            this.gbPersonal.Location = new System.Drawing.Point(34, 162);
            this.gbPersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPersonal.Name = "gbPersonal";
            this.gbPersonal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbPersonal.Size = new System.Drawing.Size(568, 382);
            this.gbPersonal.TabIndex = 10;
            this.gbPersonal.TabStop = false;
            this.gbPersonal.Text = "Personal Info";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.ForeColor = System.Drawing.Color.Black;
            this.rdbFemale.Location = new System.Drawing.Point(352, 289);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(106, 27);
            this.rdbFemale.TabIndex = 10;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.ForeColor = System.Drawing.Color.Black;
            this.rdbMale.Location = new System.Drawing.Point(218, 289);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(81, 27);
            this.rdbMale.TabIndex = 9;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Phone Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(218, 203);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(194, 47);
            this.txtNumber.TabIndex = 7;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumber.Location = new System.Drawing.Point(14, 291);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(84, 23);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Gender";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(14, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(218, 125);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 47);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(14, 138);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 23);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 47);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Black;
            this.lblAge.Location = new System.Drawing.Point(14, 340);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(49, 23);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // nudAge
            // 
            this.nudAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAge.Location = new System.Drawing.Point(218, 332);
            this.nudAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(196, 31);
            this.nudAge.TabIndex = 3;
            this.nudAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGenerate.Location = new System.Drawing.Point(996, 794);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(244, 57);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate trip!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // richtxt1
            // 
            this.richtxt1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richtxt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxt1.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxt1.Location = new System.Drawing.Point(34, 37);
            this.richtxt1.Name = "richtxt1";
            this.richtxt1.Size = new System.Drawing.Size(424, 95);
            this.richtxt1.TabIndex = 14;
            this.richtxt1.Text = "Start by entering your personal information, and select any preferences that inte" +
    "rest you. ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(684, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 95);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "Next, provide us with your trip\'s chosen date and time, and tell us a little more" +
    " on why you\'re visiting. ";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnView
            // 
            this.btnView.AutoSize = true;
            this.btnView.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnView.Location = new System.Drawing.Point(996, 708);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(244, 57);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "View Data";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(685, 825);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(72, 23);
            this.lblAdmin.TabIndex = 17;
            this.lblAdmin.Text = "Admin";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(791, 825);
            this.txtAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(148, 26);
            this.txtAdmin.TabIndex = 18;
            this.txtAdmin.TextChanged += new System.EventHandler(this.txtAdmin_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(18, 48);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(452, 45);
            this.richTextBox2.TabIndex = 19;
            this.richTextBox2.Text = "Please select a maximum of 2.";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1370, 875);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richtxt1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbPreferences);
            this.Controls.Add(this.gbTrip);
            this.Controls.Add(this.gbPersonal);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Info";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Info_Load);
            this.gbPreferences.ResumeLayout(false);
            this.gbTrip.ResumeLayout(false);
            this.gbTrip.PerformLayout();
            this.gbPersonal.ResumeLayout(false);
            this.gbPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPreferences;
        private System.Windows.Forms.CheckedListBox clbpreferences;
        private System.Windows.Forms.GroupBox gbTrip;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datetimeTrip;
        private System.Windows.Forms.GroupBox gbPersonal;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox richtxt1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}