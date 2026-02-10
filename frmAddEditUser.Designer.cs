namespace Project_19_DVDL__2nd_
{
    partial class frmAddEditUser
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
            tcpersonalInfo = new TabControl();
            TabControl1 = new TabPage();
            gbFiliter = new GroupBox();
            txtFiliter = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            ucPerson1 = new ucPerson();
            pictureBox4 = new PictureBox();
            btnNext = new Button();
            tpageUserInfo = new TabPage();
            txtConfimPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblUserID = new Label();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            cbIsActive = new CheckBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblTitle = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            btnClose = new Button();
            pictureBox3 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            tcpersonalInfo.SuspendLayout();
            TabControl1.SuspendLayout();
            gbFiliter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tpageUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tcpersonalInfo
            // 
            tcpersonalInfo.Controls.Add(TabControl1);
            tcpersonalInfo.Controls.Add(tpageUserInfo);
            tcpersonalInfo.Location = new Point(39, 143);
            tcpersonalInfo.Name = "tcpersonalInfo";
            tcpersonalInfo.SelectedIndex = 0;
            tcpersonalInfo.Size = new Size(1080, 615);
            tcpersonalInfo.TabIndex = 0;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(gbFiliter);
            TabControl1.Controls.Add(ucPerson1);
            TabControl1.Controls.Add(pictureBox4);
            TabControl1.Controls.Add(btnNext);
            TabControl1.Location = new Point(4, 29);
            TabControl1.Name = "TabControl1";
            TabControl1.Padding = new Padding(3);
            TabControl1.Size = new Size(1072, 582);
            TabControl1.TabIndex = 0;
            TabControl1.Text = "Personal Info";
            TabControl1.UseVisualStyleBackColor = true;
            TabControl1.Click += TabControl1_Click;
            // 
            // gbFiliter
            // 
            gbFiliter.Controls.Add(txtFiliter);
            gbFiliter.Controls.Add(comboBox1);
            gbFiliter.Controls.Add(label1);
            gbFiliter.Controls.Add(pictureBox6);
            gbFiliter.Controls.Add(pictureBox5);
            gbFiliter.Location = new Point(26, 46);
            gbFiliter.Name = "gbFiliter";
            gbFiliter.Size = new Size(878, 106);
            gbFiliter.TabIndex = 17;
            gbFiliter.TabStop = false;
            gbFiliter.Text = "Filiter";
            gbFiliter.Enter += gbFiliter_Enter;
            // 
            // txtFiliter
            // 
            txtFiliter.Location = new Point(388, 45);
            txtFiliter.Name = "txtFiliter";
            txtFiliter.Size = new Size(215, 27);
            txtFiliter.TabIndex = 4;
            txtFiliter.KeyPress += txtFiliter_KeyPress;
            txtFiliter.Validating += txtFiliter_Validating;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 28);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 47);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 2;
            label1.Text = "Find By: ";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Add_Person_721;
            pictureBox6.Location = new Point(656, 47);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 27);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.SearchPerson;
            pictureBox5.Location = new Point(618, 47);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 27);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // ucPerson1
            // 
            ucPerson1.Location = new Point(26, 179);
            ucPerson1.Name = "ucPerson1";
            ucPerson1.Size = new Size(889, 330);
            ucPerson1.TabIndex = 16;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Next_64;
            pictureBox4.Location = new Point(1017, 525);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(925, 514);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(133, 54);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // tpageUserInfo
            // 
            tpageUserInfo.Controls.Add(txtConfimPassword);
            tpageUserInfo.Controls.Add(txtPassword);
            tpageUserInfo.Controls.Add(txtUserName);
            tpageUserInfo.Controls.Add(lblUserID);
            tpageUserInfo.Controls.Add(pictureBox10);
            tpageUserInfo.Controls.Add(pictureBox9);
            tpageUserInfo.Controls.Add(pictureBox8);
            tpageUserInfo.Controls.Add(pictureBox7);
            tpageUserInfo.Controls.Add(cbIsActive);
            tpageUserInfo.Controls.Add(label6);
            tpageUserInfo.Controls.Add(label5);
            tpageUserInfo.Controls.Add(label4);
            tpageUserInfo.Controls.Add(label3);
            tpageUserInfo.Controls.Add(label2);
            tpageUserInfo.Location = new Point(4, 29);
            tpageUserInfo.Name = "tpageUserInfo";
            tpageUserInfo.Padding = new Padding(3);
            tpageUserInfo.Size = new Size(1072, 582);
            tpageUserInfo.TabIndex = 1;
            tpageUserInfo.Text = "User Info";
            tpageUserInfo.UseVisualStyleBackColor = true;
            tpageUserInfo.Click += tpageUserInfo_Click;
            // 
            // txtConfimPassword
            // 
            txtConfimPassword.Location = new Point(305, 252);
            txtConfimPassword.MaxLength = 20;
            txtConfimPassword.Name = "txtConfimPassword";
            txtConfimPassword.PasswordChar = '*';
            txtConfimPassword.Size = new Size(198, 27);
            txtConfimPassword.TabIndex = 13;
            txtConfimPassword.Validating += txtConfimPassword_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(307, 202);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 12;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(307, 153);
            txtUserName.MaxLength = 20;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(198, 27);
            txtUserName.TabIndex = 11;
            txtUserName.TextChanged += textBox1_TextChanged;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(305, 109);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(30, 28);
            lblUserID.TabIndex = 10;
            lblUserID.Text = "??";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Number_321;
            pictureBox10.Location = new Point(226, 248);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(31, 29);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 9;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Number_321;
            pictureBox9.Location = new Point(226, 202);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(31, 29);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Person_32;
            pictureBox8.Location = new Point(226, 156);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 29);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Number_321;
            pictureBox7.Location = new Point(226, 109);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(31, 29);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbIsActive.Location = new Point(305, 323);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.RightToLeft = RightToLeft.Yes;
            cbIsActive.Size = new Size(109, 32);
            cbIsActive.TabIndex = 5;
            cbIsActive.Text = "IsActive";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(226, 327);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 248);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 3;
            label5.Text = "Confirm Pssword";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(118, 202);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 2;
            label4.Text = "Pssword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 156);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 110);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 0;
            label2.Text = "UserID";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Red;
            lblTitle.Location = new Point(474, 58);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(74, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close_32;
            pictureBox2.Location = new Point(811, 819);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Save_32;
            pictureBox1.Location = new Point(965, 819);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(953, 804);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 54);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(797, 804);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 54);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Save_32;
            pictureBox3.Location = new Point(965, 819);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 870);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(tcpersonalInfo);
            Controls.Add(btnClose);
            Name = "frmAddEditUser";
            Text = "frmAddEditUser";
            Load += frmAddEditUser_Load;
            tcpersonalInfo.ResumeLayout(false);
            TabControl1.ResumeLayout(false);
            gbFiliter.ResumeLayout(false);
            gbFiliter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tpageUserInfo.ResumeLayout(false);
            tpageUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tcpersonalInfo;
        private TabPage TabControl1;
        private TabPage tpageUserInfo;
        private Label lblTitle;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnSave;
        private Button btnClose;
        private Button btnNext;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private ucPerson ucPerson1;
        private GroupBox gbFiliter;
        private TextBox txtFiliter;
        private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox cbIsActive;
        private Label label6;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private TextBox txtUserName;
        private Label lblUserID;
        private TextBox txtConfimPassword;
        private TextBox txtPassword;
        private ErrorProvider errorProvider1;
    }
}