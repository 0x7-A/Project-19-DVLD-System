using Microsoft.VisualBasic.ApplicationServices;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project19_businessLayer;



namespace Project_19_DVDL__2nd_
{
    public partial class usUsers : UserControl
    {
       public clsUsers User;


        public usUsers()
        {
            InitializeComponent();

        }
        public usUsers(int UserID)
        {
            InitializeComponent();
            LoadUser(UserID);
        }
       

        private void usUsers_Load(object sender, EventArgs e)
        {

        }

        public bool VerifyCurrentPassword(string enteredPassword)
        {
            return enteredPassword == User.password;
        }

        public void LoadUser(int UserID)
        {

            User = clsUsers.FindByID(UserID);

            if (User == null)
            {
                MessageBox.Show("Something went wrong");
                return;
            }


            lblUserID.Text = UserID.ToString();
            lblUsername.Text = User.userName;
            if(User.isActive)
            {
                lblIsActive.Text = "Yes";
            }
            else
            {
                lblIsActive.Text = "No";
            }
        }
    }
}
