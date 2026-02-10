namespace Project_19_DVDL__2nd_
{
    partial class frmUserInfo
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
            ucPerson1 = new ucPerson();
            usUsers1 = new usUsers();
            pictureBox12 = new PictureBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // ucPerson1
            // 
            ucPerson1.Location = new Point(23, 12);
            ucPerson1.Name = "ucPerson1";
            ucPerson1.Size = new Size(884, 342);
            ucPerson1.TabIndex = 0;
            // 
            // usUsers1
            // 
            usUsers1.Location = new Point(12, 360);
            usUsers1.Name = "usUsers1";
            usUsers1.Size = new Size(798, 111);
            usUsers1.TabIndex = 1;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.Close_32;
            pictureBox12.Location = new Point(728, 505);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(26, 22);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 60;
            pictureBox12.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(717, 494);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(167, 43);
            btnClose.TabIndex = 59;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 570);
            Controls.Add(pictureBox12);
            Controls.Add(btnClose);
            Controls.Add(usUsers1);
            Controls.Add(ucPerson1);
            Name = "frmUserInfo";
            Text = "frmUserInfo";
            Load += frmUserInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ucPerson ucPerson1;
        private usUsers usUsers1;
        protected PictureBox pictureBox12;
        protected Button btnClose;
    }
}