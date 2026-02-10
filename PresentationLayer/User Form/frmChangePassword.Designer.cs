namespace Project_19_DVDL__2nd_
{
    partial class frmChangePassword
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
            ucPerson1 = new ucPerson();
            ucUsers1 = new usUsers();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCurrentPS = new TextBox();
            txtNewPS = new TextBox();
            txtConfirmPS = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ucPerson1
            // 
            ucPerson1.Location = new Point(47, 12);
            ucPerson1.Name = "ucPerson1";
            ucPerson1.Size = new Size(890, 337);
            ucPerson1.TabIndex = 0;
            // 
            // ucUsers1
            // 
            ucUsers1.Location = new Point(35, 355);
            ucUsers1.Name = "ucUsers1";
            ucUsers1.Size = new Size(836, 114);
            ucUsers1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 487);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 2;
            label1.Text = "Current Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 535);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 3;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 584);
            label3.Name = "label3";
            label3.Size = new Size(183, 28);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            // 
            // txtCurrentPS
            // 
            txtCurrentPS.Location = new Point(240, 488);
            txtCurrentPS.MaxLength = 20;
            txtCurrentPS.Name = "txtCurrentPS";
            txtCurrentPS.PasswordChar = '*';
            txtCurrentPS.Size = new Size(257, 27);
            txtCurrentPS.TabIndex = 5;
            txtCurrentPS.Validating += txtCurrentPS_Validating;
            // 
            // txtNewPS
            // 
            txtNewPS.Location = new Point(240, 539);
            txtNewPS.MaxLength = 20;
            txtNewPS.Name = "txtNewPS";
            txtNewPS.PasswordChar = '*';
            txtNewPS.Size = new Size(257, 27);
            txtNewPS.TabIndex = 6;
            txtNewPS.Validating += txtChangePS_Validating;
            // 
            // txtConfirmPS
            // 
            txtConfirmPS.Location = new Point(240, 585);
            txtConfirmPS.MaxLength = 20;
            txtConfirmPS.Name = "txtConfirmPS";
            txtConfirmPS.PasswordChar = '*';
            txtConfirmPS.Size = new Size(257, 27);
            txtConfirmPS.TabIndex = 7;
            txtConfirmPS.Validating += txtConfirmPS_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Close_32;
            pictureBox2.Location = new Point(573, 662);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 31);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Save_32;
            pictureBox1.Location = new Point(732, 662);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(720, 647);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 54);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(564, 647);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(138, 54);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 725);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtConfirmPS);
            Controls.Add(txtNewPS);
            Controls.Add(txtCurrentPS);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ucUsers1);
            Controls.Add(ucPerson1);
            Name = "frmChangePassword";
            Text = "frmChangePassword";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ucPerson ucPerson1;
        private usUsers ucUsers1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCurrentPS;
        private TextBox txtNewPS;
        private TextBox txtConfirmPS;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnSave;
        private Button btnClose;
    }
}