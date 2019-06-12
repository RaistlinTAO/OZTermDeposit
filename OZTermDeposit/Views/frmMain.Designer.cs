namespace OZTermDeposit.Views
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmbRate = new System.Windows.Forms.ComboBox();
            this.cmbLength = new System.Windows.Forms.ComboBox();
            this.lsvResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdDetail = new System.Windows.Forms.Button();
            this.cmdShare = new System.Windows.Forms.Button();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmdGmail = new System.Windows.Forms.Button();
            this.cmdGoogleP = new System.Windows.Forms.Button();
            this.cmdFacebook = new System.Windows.Forms.Button();
            this.cmdAbout = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdClose = new System.Windows.Forms.PictureBox();
            this.cmdSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRate
            // 
            this.cmbRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRate.FormattingEnabled = true;
            this.cmbRate.Items.AddRange(new object[] {
            "1000     - 9999",
            "10000   - 24999",
            "25000   - 99999",
            "100000 - 249999",
            "250000"});
            this.cmbRate.Location = new System.Drawing.Point(64, 42);
            this.cmbRate.Name = "cmbRate";
            this.cmbRate.Size = new System.Drawing.Size(121, 21);
            this.cmbRate.TabIndex = 0;
            // 
            // cmbLength
            // 
            this.cmbLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLength.FormattingEnabled = true;
            this.cmbLength.Items.AddRange(new object[] {
            "30   days (1 month)",
            "90   days (3 month)",
            "180 days (6 month)",
            "270 days (9 month)",
            "1     year",
            "2     year",
            "3     year",
            "4     year",
            "5     year"});
            this.cmbLength.Location = new System.Drawing.Point(276, 42);
            this.cmbLength.Name = "cmbLength";
            this.cmbLength.Size = new System.Drawing.Size(121, 21);
            this.cmbLength.TabIndex = 1;
            // 
            // lsvResult
            // 
            this.lsvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lsvResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvResult.FullRowSelect = true;
            this.lsvResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvResult.Location = new System.Drawing.Point(12, 89);
            this.lsvResult.MultiSelect = false;
            this.lsvResult.Name = "lsvResult";
            this.lsvResult.Size = new System.Drawing.Size(605, 346);
            this.lsvResult.SmallImageList = this.imageList1;
            this.lsvResult.TabIndex = 2;
            this.lsvResult.UseCompatibleStateImageBehavior = false;
            this.lsvResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Institution";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Interest";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "More Details";
            this.columnHeader4.Width = 345;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 22);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Australia Term Deposits Interest Rate Comparison";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Terms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Copyright © D.E.M.O.N Studio 2006-2012. All Rights Reserved";
            // 
            // cmdDetail
            // 
            this.cmdDetail.BackColor = System.Drawing.Color.LightBlue;
            this.cmdDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDetail.Location = new System.Drawing.Point(482, 441);
            this.cmdDetail.Name = "cmdDetail";
            this.cmdDetail.Size = new System.Drawing.Size(135, 21);
            this.cmdDetail.TabIndex = 13;
            this.cmdDetail.Text = "Apply Now";
            this.cmdDetail.UseVisualStyleBackColor = false;
            this.cmdDetail.Visible = false;
            this.cmdDetail.Click += new System.EventHandler(this.cmdDetail_Click);
            // 
            // cmdShare
            // 
            this.cmdShare.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShare.Location = new System.Drawing.Point(341, 441);
            this.cmdShare.Name = "cmdShare";
            this.cmdShare.Size = new System.Drawing.Size(135, 21);
            this.cmdShare.TabIndex = 14;
            this.cmdShare.Text = "Copy Selected Result";
            this.cmdShare.UseVisualStyleBackColor = false;
            this.cmdShare.Visible = false;
            this.cmdShare.Click += new System.EventHandler(this.cmdShare_Click);
            // 
            // picLoad
            // 
            this.picLoad.Image = global::OZTermDeposit.Properties.Resources.ajax_loader__1_;
            this.picLoad.Location = new System.Drawing.Point(12, 89);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(605, 346);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoad.TabIndex = 20;
            this.picLoad.TabStop = false;
            this.picLoad.Visible = false;
            // 
            // picCover
            // 
            this.picCover.Image = ((System.Drawing.Image)(resources.GetObject("picCover.Image")));
            this.picCover.Location = new System.Drawing.Point(12, 89);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(605, 346);
            this.picCover.TabIndex = 19;
            this.picCover.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // cmdGmail
            // 
            this.cmdGmail.BackColor = System.Drawing.Color.Transparent;
            this.cmdGmail.BackgroundImage = global::OZTermDeposit.Properties.Resources._1345466362_Android_Gmail;
            this.cmdGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGmail.Location = new System.Drawing.Point(148, 441);
            this.cmdGmail.Name = "cmdGmail";
            this.cmdGmail.Size = new System.Drawing.Size(21, 21);
            this.cmdGmail.TabIndex = 17;
            this.cmdGmail.UseVisualStyleBackColor = false;
            this.cmdGmail.Click += new System.EventHandler(this.cmdGmail_Click);
            // 
            // cmdGoogleP
            // 
            this.cmdGoogleP.BackColor = System.Drawing.Color.Transparent;
            this.cmdGoogleP.BackgroundImage = global::OZTermDeposit.Properties.Resources._1345466283_square_google_plus_one__1_grey;
            this.cmdGoogleP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGoogleP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGoogleP.Location = new System.Drawing.Point(121, 441);
            this.cmdGoogleP.Name = "cmdGoogleP";
            this.cmdGoogleP.Size = new System.Drawing.Size(21, 21);
            this.cmdGoogleP.TabIndex = 16;
            this.cmdGoogleP.UseVisualStyleBackColor = false;
            this.cmdGoogleP.Click += new System.EventHandler(this.cmdGoogleP_Click);
            // 
            // cmdFacebook
            // 
            this.cmdFacebook.BackColor = System.Drawing.Color.Transparent;
            this.cmdFacebook.BackgroundImage = global::OZTermDeposit.Properties.Resources._1345466092_facebook;
            this.cmdFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdFacebook.Location = new System.Drawing.Point(94, 441);
            this.cmdFacebook.Name = "cmdFacebook";
            this.cmdFacebook.Size = new System.Drawing.Size(21, 21);
            this.cmdFacebook.TabIndex = 15;
            this.cmdFacebook.UseVisualStyleBackColor = false;
            this.cmdFacebook.Click += new System.EventHandler(this.cmdFacebook_Click);
            // 
            // cmdAbout
            // 
            this.cmdAbout.BackColor = System.Drawing.Color.Transparent;
            this.cmdAbout.Image = global::OZTermDeposit.Properties.Resources.btn_donate_SM;
            this.cmdAbout.Location = new System.Drawing.Point(12, 441);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(76, 21);
            this.cmdAbout.TabIndex = 11;
            this.cmdAbout.TabStop = false;
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = global::OZTermDeposit.Properties.Resources._1223;
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 21);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cmdClose
            // 
            this.cmdClose.Image = global::OZTermDeposit.Properties.Resources._1345451727_Close_Box_Red;
            this.cmdClose.Location = new System.Drawing.Point(607, -1);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(22, 21);
            this.cmdClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdClose.TabIndex = 5;
            this.cmdClose.TabStop = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.BackColor = System.Drawing.Color.Black;
            this.cmdSearch.Image = global::OZTermDeposit.Properties.Resources.search;
            this.cmdSearch.Location = new System.Drawing.Point(517, 42);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(100, 21);
            this.cmdSearch.TabIndex = 3;
            this.cmdSearch.TabStop = false;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            this.cmdSearch.MouseEnter += new System.EventHandler(this.cmdSearch_MouseEnter);
            this.cmdSearch.MouseLeave += new System.EventHandler(this.cmdSearch_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(629, 490);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmdGmail);
            this.Controls.Add(this.cmdGoogleP);
            this.Controls.Add(this.cmdFacebook);
            this.Controls.Add(this.cmdShare);
            this.Controls.Add(this.cmdDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdAbout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSearch);
            this.Controls.Add(this.lsvResult);
            this.Controls.Add(this.cmbLength);
            this.Controls.Add(this.cmbRate);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRate;
        private System.Windows.Forms.ComboBox cmbLength;
        private System.Windows.Forms.ListView lsvResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox cmdSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox cmdClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox cmdAbout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdDetail;
        private System.Windows.Forms.Button cmdShare;
        private System.Windows.Forms.Button cmdFacebook;
        private System.Windows.Forms.Button cmdGoogleP;
        private System.Windows.Forms.Button cmdGmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.PictureBox picLoad;
    }
}