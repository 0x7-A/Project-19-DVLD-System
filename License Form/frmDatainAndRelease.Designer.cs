namespace Project_19_DVDL__2nd_
{
    partial class frmDatainAndRelease
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
            ucDriverLicenseInfo1 = new ucDriverLicenseInfo();
            gbFilter = new GroupBox();
            pbFibdLicenseID = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            lblTitile = new Label();
            ucDetainInfo1 = new ucDetainInfo();
            ucReleaseLicenseInfo1 = new ucReleaseLicenseInfo();
            pbDetainRelease = new PictureBox();
            btnIssueReplacement = new Button();
            pictureBox2 = new PictureBox();
            btnClose = new Button();
            linkLabelShowLicenseInfo = new LinkLabel();
            linklableShowLicenseHistory = new LinkLabel();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFibdLicenseID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDetainRelease).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ucDriverLicenseInfo1
            // 
            ucDriverLicenseInfo1.Location = new Point(32, 201);
            ucDriverLicenseInfo1.Name = "ucDriverLicenseInfo1";
            ucDriverLicenseInfo1.Size = new Size(948, 369);
            ucDriverLicenseInfo1.TabIndex = 10;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(pbFibdLicenseID);
            gbFilter.Controls.Add(textBox1);
            gbFilter.Controls.Add(label2);
            gbFilter.Location = new Point(32, 84);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(658, 97);
            gbFilter.TabIndex = 9;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // pbFibdLicenseID
            // 
            pbFibdLicenseID.Image = Properties.Resources.License_View_32;
            pbFibdLicenseID.Location = new Point(574, 26);
            pbFibdLicenseID.Name = "pbFibdLicenseID";
            pbFibdLicenseID.Size = new Size(64, 52);
            pbFibdLicenseID.SizeMode = PictureBoxSizeMode.Zoom;
            pbFibdLicenseID.TabIndex = 2;
            pbFibdLicenseID.TabStop = false;
            pbFibdLicenseID.Click += pbFibdLicenseID_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 27);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 43);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 0;
            label2.Text = "LicenseID: ";
            // 
            // lblTitile
            // 
            lblTitile.AutoSize = true;
            lblTitile.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitile.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitile.Location = new Point(457, 32);
            lblTitile.Name = "lblTitile";
            lblTitile.Size = new Size(68, 35);
            lblTitile.TabIndex = 11;
            lblTitile.Text = "Title";
            // 
            // ucDetainInfo1
            // 
            ucDetainInfo1.Location = new Point(43, 577);
            ucDetainInfo1.Name = "ucDetainInfo1";
            ucDetainInfo1.Size = new Size(865, 252);
            ucDetainInfo1.TabIndex = 12;
            // 
            // ucReleaseLicenseInfo1
            // 
            ucReleaseLicenseInfo1.Location = new Point(197, 576);
            ucReleaseLicenseInfo1.Name = "ucReleaseLicenseInfo1";
            ucReleaseLicenseInfo1.Size = new Size(711, 265);
            ucReleaseLicenseInfo1.TabIndex = 13;
            // 
            // pbDetainRelease
            // 
            pbDetainRelease.Image = Properties.Resources.Detain_32;
            pbDetainRelease.Location = new Point(762, 874);
            pbDetainRelease.Name = "pbDetainRelease";
            pbDetainRelease.Size = new Size(31, 31);
            pbDetainRelease.SizeMode = PictureBoxSizeMode.Zoom;
            pbDetainRelease.TabIndex = 36;
            pbDetainRelease.TabStop = false;
            // 
            // btnIssueReplacement
            // 
            btnIssueReplacement.Enabled = false;
            btnIssueReplacement.Location = new Point(753, 859);
            btnIssueReplacement.Name = "btnIssueReplacement";
            btnIssueReplacement.Size = new Size(223, 54);
            btnIssueReplacement.TabIndex = 35;
            btnIssueReplacement.Text = "Issue Replacement";
            btnIssueReplacement.UseVisualStyleBackColor = true;
            btnIssueReplacement.Click += btnIssueReplacement_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close_32;
            pictureBox2.Location = new Point(577, 874);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(568, 859);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 54);
            btnClose.TabIndex = 33;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // linkLabelShowLicenseInfo
            // 
            linkLabelShowLicenseInfo.AutoSize = true;
            linkLabelShowLicenseInfo.Enabled = false;
            linkLabelShowLicenseInfo.Location = new Point(226, 885);
            linkLabelShowLicenseInfo.Name = "linkLabelShowLicenseInfo";
            linkLabelShowLicenseInfo.Size = new Size(127, 20);
            linkLabelShowLicenseInfo.TabIndex = 32;
            linkLabelShowLicenseInfo.TabStop = true;
            linkLabelShowLicenseInfo.Text = "Show License Info";
            linkLabelShowLicenseInfo.Click += linkLabelShowLicenseInfo_Click;
            // 
            // linklableShowLicenseHistory
            // 
            linklableShowLicenseHistory.AutoSize = true;
            linklableShowLicenseHistory.Enabled = false;
            linklableShowLicenseHistory.Location = new Point(47, 885);
            linklableShowLicenseHistory.Name = "linklableShowLicenseHistory";
            linklableShowLicenseHistory.Size = new Size(148, 20);
            linklableShowLicenseHistory.TabIndex = 31;
            linklableShowLicenseHistory.TabStop = true;
            linklableShowLicenseHistory.Text = "Show License History";
            linklableShowLicenseHistory.LinkClicked += linklableShowLicenseHistory_LinkClicked;
            // 
            // frmDatainAndRelease
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 932);
            Controls.Add(pbDetainRelease);
            Controls.Add(btnIssueReplacement);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(linkLabelShowLicenseInfo);
            Controls.Add(linklableShowLicenseHistory);
            Controls.Add(ucReleaseLicenseInfo1);
            Controls.Add(ucDetainInfo1);
            Controls.Add(lblTitile);
            Controls.Add(ucDriverLicenseInfo1);
            Controls.Add(gbFilter);
            Name = "frmDatainAndRelease";
            Text = "frmDatainAndRelease";
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFibdLicenseID).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDetainRelease).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ucDriverLicenseInfo ucDriverLicenseInfo1;
        private GroupBox gbFilter;
        private PictureBox pbFibdLicenseID;
        private TextBox textBox1;
        private Label label2;
        private Label lblTitile;
        private ucDetainInfo ucDetainInfo1;
        private ucReleaseLicenseInfo ucReleaseLicenseInfo1;
        private PictureBox pbDetainRelease;
        private Button btnIssueReplacement;
        private PictureBox pictureBox2;
        private Button btnClose;
        private LinkLabel linkLabelShowLicenseInfo;
        private LinkLabel linklableShowLicenseHistory;
    }
}