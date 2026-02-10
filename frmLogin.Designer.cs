namespace Project_19_DVDL__2nd_
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsename = new TextBox();
            chRemember = new CheckBox();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(518, 48);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 0;
            label1.Text = "Login to you account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 126);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 179);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUsename
            // 
            txtUsename.Location = new Point(530, 123);
            txtUsename.MaxLength = 20;
            txtUsename.Name = "txtUsename";
            txtUsename.Size = new Size(165, 27);
            txtUsename.TabIndex = 0;
            // 
            // chRemember
            // 
            chRemember.AutoSize = true;
            chRemember.Location = new Point(530, 222);
            chRemember.Name = "chRemember";
            chRemember.Size = new Size(129, 24);
            chRemember.TabIndex = 5;
            chRemember.Text = "Remember me";
            chRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(551, 293);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(138, 45);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconLogo;
            pictureBox1.Location = new Point(55, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.closeBlack32;
            btnClose.Location = new Point(768, 28);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(64, 49);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sign_in_32;
            pictureBox2.Location = new Point(563, 305);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 24);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 508);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 231);
            label4.Name = "label4";
            label4.Size = new Size(332, 25);
            label4.TabIndex = 11;
            label4.Text = "Welcome to my first full project DVDL";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(530, 172);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(165, 27);
            txtPassword.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Person_32;
            pictureBox3.Location = new Point(498, 125);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(23, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Number_321;
            pictureBox4.Location = new Point(498, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(23, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 496);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(txtPassword);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(chRemember);
            Controls.Add(txtUsename);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsename;
        private CheckBox chRemember;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private Button btnClose;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label4;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
