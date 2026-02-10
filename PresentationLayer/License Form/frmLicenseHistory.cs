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
    public partial class frmLicenseHistory : Form
    {
        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            ucPerson1.LoadPersonInfo(PersonID);
            ucDriverLicense1.LoadHistory(PersonID);
        }


        
        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucDriverLicense1_Load(object sender, EventArgs e)
        {

        }
    }
}
