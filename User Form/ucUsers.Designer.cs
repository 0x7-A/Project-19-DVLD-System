namespace Project_19_DVDL__2nd_
{
    partial class usUsers
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
            groupBox1 = new GroupBox();
            lblIsActive = new Label();
            label3 = new Label();
            lblUsername = new Label();
            label2 = new Label();
            lblUserID = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblIsActive);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblUserID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "login Information";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIsActive.Location = new Point(687, 43);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(23, 20);
            lblIsActive.TabIndex = 5;
            lblIsActive.Text = "??";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(596, 43);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 4;
            label3.Text = "Is Active : ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsername.Location = new Point(397, 43);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(23, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(305, 43);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Username : ";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserID.Location = new Point(105, 43);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(23, 20);
            lblUserID.TabIndex = 1;
            lblUserID.Text = "??";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(32, 43);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "User ID";
            // 
            // usUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "usUsers";
            Size = new Size(825, 129);
            Load += usUsers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblIsActive;
        private Label label3;
        private Label lblUsername;
        private Label label2;
        private Label lblUserID;
        private Label label1;
    }
}
