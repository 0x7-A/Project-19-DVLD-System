namespace Project_19_DVDL__2nd_
{
    partial class ucDriverLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tappage3 = new TabPage();
            lblTotalLocalRecords = new Label();
            label2 = new Label();
            dgvLocalLicenseHistory = new DataGridView();
            label1 = new Label();
            tabPage2 = new TabPage();
            lblTotalInternationalRecords = new Label();
            label4 = new Label();
            dgvInternationalLicense = new DataGridView();
            label3 = new Label();
            cmShowLocalLicense = new ContextMenuStrip(components);
            showLicenseInfoToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tappage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenseHistory).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicense).BeginInit();
            cmShowLocalLicense.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(6, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1060, 497);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tappage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(18, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1005, 429);
            tabControl1.TabIndex = 0;
            // 
            // tappage3
            // 
            tappage3.Controls.Add(lblTotalLocalRecords);
            tappage3.Controls.Add(label2);
            tappage3.Controls.Add(dgvLocalLicenseHistory);
            tappage3.Controls.Add(label1);
            tappage3.Location = new Point(4, 29);
            tappage3.Name = "tappage3";
            tappage3.Padding = new Padding(3);
            tappage3.Size = new Size(997, 396);
            tappage3.TabIndex = 0;
            tappage3.Text = "Local";
            tappage3.UseVisualStyleBackColor = true;
            // 
            // lblTotalLocalRecords
            // 
            lblTotalLocalRecords.AutoSize = true;
            lblTotalLocalRecords.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLocalRecords.Location = new Point(102, 373);
            lblTotalLocalRecords.Name = "lblTotalLocalRecords";
            lblTotalLocalRecords.Size = new Size(18, 20);
            lblTotalLocalRecords.TabIndex = 3;
            lblTotalLocalRecords.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 373);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 2;
            label2.Text = "# Records: ";
            // 
            // dgvLocalLicenseHistory
            // 
            dgvLocalLicenseHistory.AllowUserToAddRows = false;
            dgvLocalLicenseHistory.AllowUserToDeleteRows = false;
            dgvLocalLicenseHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalLicenseHistory.ContextMenuStrip = cmShowLocalLicense;
            dgvLocalLicenseHistory.Location = new Point(10, 72);
            dgvLocalLicenseHistory.Name = "dgvLocalLicenseHistory";
            dgvLocalLicenseHistory.ReadOnly = true;
            dgvLocalLicenseHistory.RowHeadersWidth = 51;
            dgvLocalLicenseHistory.Size = new Size(975, 288);
            dgvLocalLicenseHistory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 35);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 0;
            label1.Text = "Local Licenses History";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblTotalInternationalRecords);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(dgvInternationalLicense);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(997, 396);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "International";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalInternationalRecords
            // 
            lblTotalInternationalRecords.AutoSize = true;
            lblTotalInternationalRecords.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalInternationalRecords.Location = new Point(114, 369);
            lblTotalInternationalRecords.Name = "lblTotalInternationalRecords";
            lblTotalInternationalRecords.Size = new Size(18, 20);
            lblTotalInternationalRecords.TabIndex = 3;
            lblTotalInternationalRecords.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 369);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 2;
            label4.Text = "# Records";
            // 
            // dgvInternationalLicense
            // 
            dgvInternationalLicense.AllowUserToAddRows = false;
            dgvInternationalLicense.AllowUserToDeleteRows = false;
            dgvInternationalLicense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicense.ContextMenuStrip = cmShowLocalLicense;
            dgvInternationalLicense.Location = new Point(6, 60);
            dgvInternationalLicense.Name = "dgvInternationalLicense";
            dgvInternationalLicense.ReadOnly = true;
            dgvInternationalLicense.RowHeadersWidth = 51;
            dgvInternationalLicense.Size = new Size(968, 292);
            dgvInternationalLicense.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 0;
            label3.Text = "International License";
            // 
            // cmShowLocalLicense
            // 
            cmShowLocalLicense.ImageScalingSize = new Size(20, 20);
            cmShowLocalLicense.Items.AddRange(new ToolStripItem[] { showLicenseInfoToolStripMenuItem });
            cmShowLocalLicense.Name = "cmShowLocalLicense";
            cmShowLocalLicense.Size = new Size(215, 58);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            showLicenseInfoToolStripMenuItem.Image = Properties.Resources.License_View_32;
            showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            showLicenseInfoToolStripMenuItem.Size = new Size(214, 26);
            showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            showLicenseInfoToolStripMenuItem.Click += showLicenseInfoToolStripMenuItem_Click;
            // 
            // ucDriverLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ucDriverLicense";
            Size = new Size(1084, 528);
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tappage3.ResumeLayout(false);
            tappage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicenseHistory).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicense).EndInit();
            cmShowLocalLicense.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabPage tappage3;
        private TabPage tabPage2;
        private Label label2;
        private DataGridView dgvLocalLicenseHistory;
        private Label label1;
        private Label lblTotalLocalRecords;
        private Label lblTotalInternationalRecords;
        private Label label4;
        private DataGridView dgvInternationalLicense;
        private Label label3;
        public TabControl tabControl1;
        private ContextMenuStrip cmShowLocalLicense;
        private ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}
