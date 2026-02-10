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
    public partial class frmReplacmentForDemagedLostLicense : Form
    {
        clsLicense License;
        decimal Fees = 0;
        public frmReplacmentForDemagedLostLicense()
        {
            InitializeComponent();
            Check();
            FillBasicInfo();
        }

        private void FillBasicInfo()
        {
            ucApplicationInfoForDamagedLostLicense1.lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            ucApplicationInfoForDamagedLostLicense1.lblCreatedBy.Text = clsSystem.CurrentUser.userName;
            ucApplicationInfoForDamagedLostLicense1.lblApplicationFee.Text = Fees.ToString();
        }


        private void FillInfoAfterLicenseFound()
        {
            ucApplicationInfoForDamagedLostLicense1.lblOldLicenseID.Text = textBox1.Text;

        }

        private void Check()
        {
            string any = "";
            if (rbDamagedLicense.Checked)
            {
                clsManageAppTypes.GetApplicationFeesAndDescription((int)clsApplication.enApplicationType.ReplacementforaDamagedDrivingLicense, ref Fees, ref any);
            }
            else
            {
                clsManageAppTypes.GetApplicationFeesAndDescription((int)clsApplication.enApplicationType.ReplacementforaLostDrivingLicense, ref Fees, ref any);
            }
        }

        private void pbFibdLicenseID_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBox1.Text)) return;


            License = clsLicense.Find(int.Parse(textBox1.Text));


            if (License == null)
            {
                MessageBox.Show("License not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }




            gbFilter.Enabled = false;

            Check();
            ucDriverLicenseInfo1.Load(License);
            ucApplicationInfoForDamagedLostLicense1.lblOldLicenseID.Text = textBox1.Text;
            linklableShowLicenseHistory.Enabled = true;
            btnIssueReplacement.Enabled = true;
            gbReplacementFor.Enabled = true;
            rbDamagedLicense.Checked = true;

        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            string ErrorMessage = "";
            if (!clsLicense.CanGetreplacementLicense(ref ErrorMessage, License.ExpirationDate, License.IsActive, License.LicenseID))
            {
                MessageBox.Show(ErrorMessage);
                return;
            }

            int NewApplicationID = clsLocalAppcs.AddNewApplication(License.ApplicationInfo.ApplicantPersonID,
                License.LicenseClass, (rbDamagedLicense.Checked) ? clsApplication.enApplicationType.ReplacementforaDamagedDrivingLicense : clsApplication.enApplicationType.ReplacementforaLostDrivingLicense
                , clsApplication.enApplicationStatus.Completed);

            if (NewApplicationID == -1)
            {
                MessageBox.Show("Somthing went wrong");
                return;
            }


            int NewLicenseID = clsLicense.GetReplacementLicense(License.LicenseID, NewApplicationID, License.DriverID, License.LicenseClass, License.ExpirationDate
                , Fees, License.Notes, clsSystem.CurrentUser.UserID, (rbDamagedLicense.Checked) ? clsLicense.enIssueReason.ReplacementDamaged : clsLicense.enIssueReason.ReplacementLost);


            if (NewLicenseID == -1)
            {
                MessageBox.Show("Somthing went wrong");
                return;
            }


            ucApplicationInfoForDamagedLostLicense1.lblReplacedLicenseID.Text = NewLicenseID.ToString();
            ucApplicationInfoForDamagedLostLicense1.lblReplacementAppID.Text = NewApplicationID.ToString();
            gbReplacementFor.Enabled = false;
            btnIssueReplacement.Enabled = false;
            linkLabelShowLicenseInfo.Enabled = true;
            License = clsLicense.Find(NewLicenseID);

            MessageBox.Show("Succefully Added Replacement License with ID: " + NewLicenseID, " Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }









        private void linklableShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(License.ApplicationInfo.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void linkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(License);
            frm.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
