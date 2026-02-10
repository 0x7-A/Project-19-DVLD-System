using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_19_DVDL__2nd_
{
    public partial class frmUserInfo : Form
    {
        public frmUserInfo(int PersonID, int UserID)
        {
            InitializeComponent();
            ucPerson1.LoadPersonInfo(PersonID);
            usUsers1.LoadUser(UserID);
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
