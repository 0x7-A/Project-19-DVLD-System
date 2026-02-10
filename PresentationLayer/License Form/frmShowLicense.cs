using System;
using Project19_businessLayer;
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
    public partial class frmShowLicense : Form
    {
        private clsPerson person;
        private clsLicense _License;
        public frmShowLicense(int LDLAppID, string NationalNo)
        {
            InitializeComponent();
            person = clsPerson.FindPersonByNationalNo(NationalNo);
             _License    =  clsLicense.FindLicenseByLDLAppID(LDLAppID);
            if (_License  == null || person  == null)
            {
                MessageBox.Show("somthing went wrong");
                return;
            }
            ucLicenseInfo1.LoadInfos(person,_License);
        }

        public frmShowLicense(clsLicense License)
        {
            InitializeComponent();
            if (License == null )
            {
                MessageBox.Show("somthing went wrong");
                return;
            }
            ucLicenseInfo1.LoadInfos(License);
        }


        // overload using licenseID
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
