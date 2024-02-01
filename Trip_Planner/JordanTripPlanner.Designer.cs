namespace Trip_Planner
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblintro = new System.Windows.Forms.Label();
            this.btnTrip = new System.Windows.Forms.Button();
            this.description_txtbox = new System.Windows.Forms.RichTextBox();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privacyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.lblPetra = new System.Windows.Forms.Label();
            this.lblKingTalalDam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picMinistry = new System.Windows.Forms.PictureBox();
            this.picPetra = new System.Windows.Forms.PictureBox();
            this.picKingTalalDam = new System.Windows.Forms.PictureBox();
            this.picWadiRum = new System.Windows.Forms.PictureBox();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinistry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPetra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKingTalalDam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWadiRum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblintro
            // 
            this.lblintro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblintro.AutoSize = true;
            this.lblintro.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblintro.Location = new System.Drawing.Point(285, 105);
            this.lblintro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblintro.Name = "lblintro";
            this.lblintro.Size = new System.Drawing.Size(562, 44);
            this.lblintro.TabIndex = 0;
            this.lblintro.Text = "Your perfect trip is just clicks away!";
            this.lblintro.Click += new System.EventHandler(this.lblintro_Click);
            // 
            // btnTrip
            // 
            this.btnTrip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrip.AutoSize = true;
            this.btnTrip.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTrip.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrip.ForeColor = System.Drawing.Color.Snow;
            this.btnTrip.Location = new System.Drawing.Point(501, 445);
            this.btnTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(203, 70);
            this.btnTrip.TabIndex = 1;
            this.btnTrip.Text = "Generate Trip";
            this.btnTrip.UseVisualStyleBackColor = false;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
            // 
            // description_txtbox
            // 
            this.description_txtbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.description_txtbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.description_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description_txtbox.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_txtbox.Location = new System.Drawing.Point(192, 203);
            this.description_txtbox.Name = "description_txtbox";
            this.description_txtbox.Size = new System.Drawing.Size(788, 197);
            this.description_txtbox.TabIndex = 5;
            this.description_txtbox.Text = resources.GetString("description_txtbox.Text");
            this.description_txtbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // aboutItem
            // 
            this.aboutItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(100, 26);
            this.aboutItem.Text = "About us ";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // helpItem
            // 
            this.helpItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteItem,
            this.ApplyItem});
            this.helpItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpItem.Name = "helpItem";
            this.helpItem.Size = new System.Drawing.Size(62, 26);
            this.helpItem.Text = "Help";
            // 
            // websiteItem
            // 
            this.websiteItem.Name = "websiteItem";
            this.websiteItem.Size = new System.Drawing.Size(295, 34);
            this.websiteItem.Text = "Ministry of Tourism Site";
            this.websiteItem.Click += new System.EventHandler(this.websiteItem_Click);
            // 
            // ApplyItem
            // 
            this.ApplyItem.Name = "ApplyItem";
            this.ApplyItem.Size = new System.Drawing.Size(295, 34);
            this.ApplyItem.Text = "How to Apply";
            this.ApplyItem.Click += new System.EventHandler(this.ApplyItem_Click);
            // 
            // privacyItem
            // 
            this.privacyItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privacyItem.Name = "privacyItem";
            this.privacyItem.Size = new System.Drawing.Size(132, 26);
            this.privacyItem.Text = "Privacy Policy";
            this.privacyItem.Click += new System.EventHandler(this.privacyItem_Click);
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menu1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutItem,
            this.helpItem,
            this.privacyItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(1196, 30);
            this.menu1.TabIndex = 3;
            // 
            // lblPetra
            // 
            this.lblPetra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPetra.AutoSize = true;
            this.lblPetra.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetra.Location = new System.Drawing.Point(196, 860);
            this.lblPetra.Name = "lblPetra";
            this.lblPetra.Size = new System.Drawing.Size(52, 22);
            this.lblPetra.TabIndex = 10;
            this.lblPetra.Text = "Petra";
            this.lblPetra.Click += new System.EventHandler(this.lblPetra_Click);
            // 
            // lblKingTalalDam
            // 
            this.lblKingTalalDam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKingTalalDam.AutoSize = true;
            this.lblKingTalalDam.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKingTalalDam.Location = new System.Drawing.Point(528, 860);
            this.lblKingTalalDam.Name = "lblKingTalalDam";
            this.lblKingTalalDam.Size = new System.Drawing.Size(157, 22);
            this.lblKingTalalDam.TabIndex = 11;
            this.lblKingTalalDam.Text = "The King Talal Dam";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(911, 860);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wadi Rum\'s night sky";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "A few of Jordan\'s spectactular sights:";
            // 
            // picMinistry
            // 
            this.picMinistry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinistry.Image = global::Trip_Planner.Properties.Resources._2020_05;
            this.picMinistry.Location = new System.Drawing.Point(978, 42);
            this.picMinistry.Name = "picMinistry";
            this.picMinistry.Size = new System.Drawing.Size(206, 155);
            this.picMinistry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinistry.TabIndex = 14;
            this.picMinistry.TabStop = false;
            this.picMinistry.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picPetra
            // 
            this.picPetra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picPetra.Image = global::Trip_Planner.Properties.Resources._2bf1faac5c1e26d5cb94128cf762517a_petra;
            this.picPetra.Location = new System.Drawing.Point(100, 650);
            this.picPetra.Name = "picPetra";
            this.picPetra.Size = new System.Drawing.Size(262, 183);
            this.picPetra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPetra.TabIndex = 15;
            this.picPetra.TabStop = false;
            // 
            // picKingTalalDam
            // 
            this.picKingTalalDam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picKingTalalDam.Image = global::Trip_Planner.Properties.Resources.king_talal_dam1;
            this.picKingTalalDam.Location = new System.Drawing.Point(470, 650);
            this.picKingTalalDam.Name = "picKingTalalDam";
            this.picKingTalalDam.Size = new System.Drawing.Size(259, 183);
            this.picKingTalalDam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKingTalalDam.TabIndex = 16;
            this.picKingTalalDam.TabStop = false;
            // 
            // picWadiRum
            // 
            this.picWadiRum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picWadiRum.Image = global::Trip_Planner.Properties.Resources.shutterstock_1319299538__1__5e32432c08d4e;
            this.picWadiRum.Location = new System.Drawing.Point(870, 650);
            this.picWadiRum.Name = "picWadiRum";
            this.picWadiRum.Size = new System.Drawing.Size(259, 183);
            this.picWadiRum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWadiRum.TabIndex = 17;
            this.picWadiRum.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1196, 938);
            this.Controls.Add(this.picWadiRum);
            this.Controls.Add(this.picKingTalalDam);
            this.Controls.Add(this.picPetra);
            this.Controls.Add(this.picMinistry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKingTalalDam);
            this.Controls.Add(this.lblPetra);
            this.Controls.Add(this.description_txtbox);
            this.Controls.Add(this.btnTrip);
            this.Controls.Add(this.lblintro);
            this.Controls.Add(this.menu1);
            this.MainMenuStrip = this.menu1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHome";
            this.Text = "Jordan Trip Planner";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinistry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPetra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKingTalalDam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWadiRum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblintro;
        private System.Windows.Forms.Button btnTrip;
        private System.Windows.Forms.RichTextBox description_txtbox;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.ToolStripMenuItem helpItem;
        private System.Windows.Forms.ToolStripMenuItem websiteItem;
        private System.Windows.Forms.ToolStripMenuItem ApplyItem;
        private System.Windows.Forms.ToolStripMenuItem privacyItem;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.Label lblPetra;
        private System.Windows.Forms.Label lblKingTalalDam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picMinistry;
        private System.Windows.Forms.PictureBox picPetra;
        private System.Windows.Forms.PictureBox picKingTalalDam;
        private System.Windows.Forms.PictureBox picWadiRum;
    }
}

