namespace Project_19_DVDL__2nd_
{
    partial class frmTestTypes
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            button1 = new Button();
            label1 = new Label();
            lblTotalRecord = new Label();
            contextMenuStripUpdateTestType = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStripUpdateTestType.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStripUpdateTestType;
            dataGridView1.Location = new Point(0, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(998, 331);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Test_Type_64;
            pictureBox1.Location = new Point(428, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(406, 145);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(214, 31);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Manage Test Types";
            // 
            // button1
            // 
            button1.Location = new Point(857, 543);
            button1.Name = "button1";
            button1.Size = new Size(125, 34);
            button1.TabIndex = 3;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 557);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 4;
            label1.Text = "# Records";
            // 
            // lblTotalRecord
            // 
            lblTotalRecord.AutoSize = true;
            lblTotalRecord.Font = new Font("Nirmala Text", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalRecord.Location = new Point(133, 563);
            lblTotalRecord.Name = "lblTotalRecord";
            lblTotalRecord.Size = new Size(22, 25);
            lblTotalRecord.TabIndex = 5;
            lblTotalRecord.Text = "0";
            // 
            // contextMenuStripUpdateTestType
            // 
            contextMenuStripUpdateTestType.ImageScalingSize = new Size(20, 20);
            contextMenuStripUpdateTestType.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            contextMenuStripUpdateTestType.Name = "contextMenuStripUpdateTestType";
            contextMenuStripUpdateTestType.Size = new Size(211, 56);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(210, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // frmTestTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 603);
            Controls.Add(lblTotalRecord);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "frmTestTypes";
            Text = "frmTestTypes";
            Load += frmTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStripUpdateTestType.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Button button1;
        private Label label1;
        private Label lblTotalRecord;
        private ContextMenuStrip contextMenuStripUpdateTestType;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}