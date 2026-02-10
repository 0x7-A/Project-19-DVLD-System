using Project19_businessLayer;

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
    public partial class frmIssueDrivingLicenseForTheFirstTime : Form
    {
        clsLocalAppcs LocalAppcs;

        public frmIssueDrivingLicenseForTheFirstTime(int LDL, int PersonID)
        {
            InitializeComponent();
            LocalAppcs = clsLocalAppcs.FindByLocalDrivingAppID(LDL);
            if (LocalAppcs == null)
            {
                return;
            }
            ucApplicationBasicInfo1.LoadObject(LocalAppcs.APPLICATION);
            ucdlApplicationInfo1.Loadobject(LocalAppcs);


        }

        private void ucApplicationBasicInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            int DriverID = clsDrivers.AddNewDriverAndCheck(LocalAppcs.APPLICATION.ApplicantPersonID, clsSystem.CurrentUser.UserID);
            if(DriverID == -1)
            {
                MessageBox.Show("Something went wrong");
                return;
            }

            int ClassLicesneID = clsLicenseClasses.GetClassLicenseIDUseingClassName(LocalAppcs.LicenseClassName);
            int NewLicense = clsLicense.AddNewLicense(LocalAppcs.APPLICATION.ApplicationID, DriverID, ClassLicesneID, textBox1.Text, LocalAppcs.APPLICATION.PaidFees, (int) clsLicense.enIssueReason.FirstTime , clsSystem.CurrentUser.UserID);

            clsLocalAppcs.UpdateToCancelled(LocalAppcs.APPLICATION.ApplicantPersonID,ClassLicesneID);

             if(NewLicense != 1)
            {
                MessageBox.Show("Successfully Add a license" + NewLicense);
            }

        }
    }
}
