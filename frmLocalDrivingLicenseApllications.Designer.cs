namespace Project_19_DVDL__2nd_
{
    partial class frmLocalDrivingLicenseApplications
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
            lblrecord = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cmShowApplicationDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            editApplicationToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            cancleApplictionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cmSechduleTestsToolStripMenuItem = new ToolStripMenuItem();
            visionTestToolStripMenuItem = new ToolStripMenuItem();
            writtenTestToolStripMenuItem = new ToolStripMenuItem();
            streetTestToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            cmIssueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            nullll = new ToolStripSeparator();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showPersonLicenseHistoryToolStripMenuItem1 = new ToolStripMenuItem();
            lblTitle = new Label();
            pbTitle = new PictureBox();
            txtFiliter = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblrecord
            // 
            lblrecord.AutoSize = true;
            lblrecord.Location = new Point(124, 588);
            lblrecord.Name = "lblrecord";
            lblrecord.Size = new Size(17, 20);
            lblrecord.TabIndex = 41;
            lblrecord.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 588);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 40;
            label1.Text = "#Records ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Close_32;
            pictureBox1.Location = new Point(1063, 588);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 32);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(100, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 38;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 219);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 37;
            label2.Text = "Filiter By:";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1052, 572);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 63);
            btnClose.TabIndex = 35;
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
            dataGridView1.Location = new Point(12, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1197, 283);
            dataGridView1.TabIndex = 34;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cmShowApplicationDetailsToolStripMenuItem, toolStripMenuItem1, editApplicationToolStripMenuItem, deleteApplicationToolStripMenuItem, cancleApplictionToolStripMenuItem, toolStripMenuItem2, cmSechduleTestsToolStripMenuItem, toolStripMenuItem3, cmIssueDrivingLicenseFirstTimeToolStripMenuItem, nullll, showLicenseToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(294, 264);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // cmShowApplicationDetailsToolStripMenuItem
            // 
            cmShowApplicationDetailsToolStripMenuItem.Image = Properties.Resources.PersonDetails_322;
            cmShowApplicationDetailsToolStripMenuItem.Name = "cmShowApplicationDetailsToolStripMenuItem";
            cmShowApplicationDetailsToolStripMenuItem.Size = new Size(293, 26);
            cmShowApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(290, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            editApplicationToolStripMenuItem.Image = Properties.Resources.edit_32;
            editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            editApplicationToolStripMenuItem.Size = new Size(293, 26);
            editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.Image = Properties.Resources.Delete_32_2;
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(293, 26);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // cancleApplictionToolStripMenuItem
            // 
            cancleApplictionToolStripMenuItem.Image = Properties.Resources.Delete_32;
            cancleApplictionToolStripMenuItem.Name = "cancleApplictionToolStripMenuItem";
            cancleApplictionToolStripMenuItem.Size = new Size(293, 26);
            cancleApplictionToolStripMenuItem.Text = "Cancle Appliction";
            cancleApplictionToolStripMenuItem.Click += cancleApplictionToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(290, 6);
            // 
            // cmSechduleTestsToolStripMenuItem
            // 
            cmSechduleTestsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { visionTestToolStripMenuItem, writtenTestToolStripMenuItem, streetTestToolStripMenuItem });
            cmSechduleTestsToolStripMenuItem.Image = Properties.Resources.Test_32;
            cmSechduleTestsToolStripMenuItem.Name = "cmSechduleTestsToolStripMenuItem";
            cmSechduleTestsToolStripMenuItem.Size = new Size(293, 26);
            cmSechduleTestsToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // visionTestToolStripMenuItem
            // 
            visionTestToolStripMenuItem.Image = Properties.Resources.Vision_512;
            visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            visionTestToolStripMenuItem.Size = new Size(235, 26);
            visionTestToolStripMenuItem.Text = "Sechdule Vision Test";
            visionTestToolStripMenuItem.Click += visionTestToolStripMenuItem_Click;
            // 
            // writtenTestToolStripMenuItem
            // 
            writtenTestToolStripMenuItem.Image = Properties.Resources.Written_Test_512;
            writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            writtenTestToolStripMenuItem.Size = new Size(235, 26);
            writtenTestToolStripMenuItem.Text = "Sechdule Written Test";
            writtenTestToolStripMenuItem.Click += writtenTestToolStripMenuItem_Click;
            // 
            // streetTestToolStripMenuItem
            // 
            streetTestToolStripMenuItem.Image = Properties.Resources.Street_Test_32;
            streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
            streetTestToolStripMenuItem.Size = new Size(235, 26);
            streetTestToolStripMenuItem.Text = "Sechdule Street Test";
            streetTestToolStripMenuItem.Click += streetTestToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(290, 6);
            // 
            // cmIssueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            cmIssueDrivingLicenseFirstTimeToolStripMenuItem.Image = Properties.Resources.Driver_License_48;
            cmIssueDrivingLicenseFirstTimeToolStripMenuItem.Name = "cmIssueDrivingLicenseFirstTimeToolStripMenuItem";
            cmIssueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(293, 26);
            cmIssueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First time)";
            cmIssueDrivingLicenseFirstTimeToolStripMenuItem.Click += cmIssueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // nullll
            // 
            nullll.Name = "nullll";
            nullll.Size = new Size(290, 6);
            nullll.Click += showLicenseToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.Image = Properties.Resources.LicenseView_4001;
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(293, 26);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click_1;
            // 
            // showPersonLicenseHistoryToolStripMenuItem1
            // 
            showPersonLicenseHistoryToolStripMenuItem1.Image = Properties.Resources.PersonLicenseHistory_5121;
            showPersonLicenseHistoryToolStripMenuItem1.Name = "showPersonLicenseHistoryToolStripMenuItem1";
            showPersonLicenseHistoryToolStripMenuItem1.Size = new Size(293, 26);
            showPersonLicenseHistoryToolStripMenuItem1.Text = "Show Person License History";
            showPersonLicenseHistoryToolStripMenuItem1.Click += showPersonLicenseHistoryToolStripMenuItem1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Firebrick;
            lblTitle.Location = new Point(338, 166);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(456, 38);
            lblTitle.TabIndex = 33;
            lblTitle.Text = "Local driving Licsense Applications";
            // 
            // pbTitle
            // 
            pbTitle.Image = Properties.Resources.Manage_Applications_64;
            pbTitle.Location = new Point(479, 12);
            pbTitle.Name = "pbTitle";
            pbTitle.Size = new Size(202, 134);
            pbTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pbTitle.TabIndex = 32;
            pbTitle.TabStop = false;
            // 
            // txtFiliter
            // 
            txtFiliter.Location = new Point(293, 221);
            txtFiliter.Name = "txtFiliter";
            txtFiliter.Size = new Size(183, 27);
            txtFiliter.TabIndex = 30;
            txtFiliter.TextChanged += txtFilterValue_TextChanged;
            txtFiliter.KeyPress += txtFiliter_KeyPress;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Local_32;
            pictureBox2.Location = new Point(632, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.New_Application_641;
            pictureBox3.Location = new Point(1135, 187);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 43;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // frmLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 703);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
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
            Name = "frmLocalDrivingLicenseApplications";
            Text = "Local Driving License Applications";
            Load += frmLocalDrivingLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        public PictureBox pictureBox3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cmShowApplicationDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editApplicationToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripMenuItem cancleApplictionToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem cmSechduleTestsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem cmIssueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripSeparator nullll;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem1;
        private ToolStripMenuItem visionTestToolStripMenuItem;
        private ToolStripMenuItem writtenTestToolStripMenuItem;
        private ToolStripMenuItem streetTestToolStripMenuItem;
    }
}