namespace Project_19_DVDL__2nd_
{
    partial class frmManageDetainedLicense
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
            components = new System.ComponentModel.Container();
            pbAddNewInternationalLicense = new PictureBox();
            lblrecord = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            showPersonHistoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            lblTitle = new Label();
            pbTitle = new PictureBox();
            txtFiliter = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAddNewInternationalLicense).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pbAddNewInternationalLicense
            // 
            pbAddNewInternationalLicense.BorderStyle = BorderStyle.FixedSingle;
            pbAddNewInternationalLicense.Image = Properties.Resources.Detain_512;
            pbAddNewInternationalLicense.Location = new Point(1140, 187);
            pbAddNewInternationalLicense.Name = "pbAddNewInternationalLicense";
            pbAddNewInternationalLicense.Size = new Size(64, 52);
            pbAddNewInternationalLicense.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddNewInternationalLicense.TabIndex = 66;
            pbAddNewInternationalLicense.TabStop = false;
            pbAddNewInternationalLicense.Click += pbAddNewInternationalLicense_Click;
            // 
            // lblrecord
            // 
            lblrecord.AutoSize = true;
            lblrecord.Location = new Point(119, 588);
            lblrecord.Name = "lblrecord";
            lblrecord.Size = new Size(17, 20);
            lblrecord.TabIndex = 64;
            lblrecord.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 588);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 63;
            label1.Text = "#Records ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Close_32;
            pictureBox1.Location = new Point(1058, 588);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 32);
            pictureBox1.TabIndex = 62;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(95, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 61;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 219);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 60;
            label2.Text = "Filiter By:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1047, 572);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 63);
            btnClose.TabIndex = 59;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(7, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1197, 283);
            dataGridView1.TabIndex = 58;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, showLicenseDetailsToolStripMenuItem, showPersonHistoryToolStripMenuItem, toolStripMenuItem1, releaseDetainedLicenseToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(243, 114);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_32;
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(242, 26);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            showLicenseDetailsToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            showLicenseDetailsToolStripMenuItem.Size = new Size(242, 26);
            showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            showLicenseDetailsToolStripMenuItem.Click += showLicenseDetailsToolStripMenuItem_Click;
            // 
            // showPersonHistoryToolStripMenuItem
            // 
            showPersonHistoryToolStripMenuItem.Image = Properties.Resources.PersonLicenseHistory_32;
            showPersonHistoryToolStripMenuItem.Name = "showPersonHistoryToolStripMenuItem";
            showPersonHistoryToolStripMenuItem.Size = new Size(242, 26);
            showPersonHistoryToolStripMenuItem.Text = "Show Person History";
            showPersonHistoryToolStripMenuItem.Click += showPersonHistoryToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(239, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = Properties.Resources.Release_Detained_License_64;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(242, 26);
            releaseDetainedLicenseToolStripMenuItem.Text = "Realse Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(415, 166);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(283, 38);
            lblTitle.TabIndex = 57;
            lblTitle.Text = "List Detained License";
            // 
            // pbTitle
            // 
            pbTitle.Image = Properties.Resources.Detain_512;
            pbTitle.Location = new Point(474, 12);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(202, 134);
            pbTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbTitle.TabIndex = 56;
            pbTitle.TabStop = false;
            // 
            // txtFiliter
            // 
            txtFiliter.Location = new Point(288, 221);
            txtFiliter.Name = "txtFiliter";
            txtFiliter.Size = new Size(183, 27);
            txtFiliter.TabIndex = 55;
            txtFiliter.TextChanged += txtFiliter_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Image = Properties.Resources.Release_Detained_License_64;
            pictureBox2.Location = new Point(1058, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmManageDetainedLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 663);
            Controls.Add(pictureBox2);
            Controls.Add(pbAddNewInternationalLicense);
            Controls.Add(lblrecord);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(pbTitle);
            Controls.Add(txtFiliter);
            Name = "frmManageDetainedLicense";
            Text = "List Detained License";
            ((System.ComponentModel.ISupportInitialize)pbAddNewInternationalLicense).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pbAddNewInternationalLicense;
        public Label lblrecord;
        public Label label1;
        public PictureBox pictureBox1;
        public ComboBox comboBox1;
        public Label label2;
        public Button btnClose;
        public DataGridView dataGridView1;
        public Label lblTitle;
        public PictureBox pbTitle;
        private TextBox txtFiliter;
        public PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private ToolStripMenuItem showPersonHistoryToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}