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
    public partial class frmRenewLicensecs : Form
    {
        clsLicense License;
        clsLicenseClasses LicenseClasses;
        decimal Fees;
      

        public frmRenewLicensecs()
        {
            InitializeComponent();
            FillDateandUserInfoandFees();
        }

        private void FillDateandUserInfoandFees()
        {
            ucNewAppicationaLicenseInfocs1.lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            ucNewAppicationaLicenseInfocs1.lblIssueDate.Text = DateTime.Now.ToShortDateString();
            ucNewAppicationaLicenseInfocs1.lblCreatedBy.Text = clsSystem.CurrentUser.userName;
            ucNewAppicationaLicenseInfocs1.lblApplicationFees.Text = clsSystem.NewApplicationsFees.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Check()
        {
            string any = "";

            clsManageAppTypes.GetApplicationFeesAndDescription((int)clsApplication.enApplicationType.RenewDrivingLicenseService, ref Fees, ref any);
        }

        private void pbFibdLicenseID_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBox1.Text)) return;


            License = clsLicense.Find(int.Parse(textBox1.Text));


            if (License == null)
            {
                MessageBox.Show("License not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            LicenseClasses = clsLicenseClasses.FindClassInfoByLicenseID(License.LicenseClass);

            if (LicenseClasses == null)
            {
                return;
            }


            gbFilter.Enabled = false;
           
            Check();
            ucDriverLicenseInfo1.Load(License);
            FillucRnewApplication();
            linklableShowLicenseHistory.Enabled = true;
            btnRenew.Enabled = true;

        }


        private void FillucRnewApplication()
        {
            ucNewAppicationaLicenseInfocs1.lblRenewOldLicenseID.Text = textBox1.Text;
            ucNewAppicationaLicenseInfocs1.lblExpirationate.Text = DateTime.Now.AddYears(LicenseClasses.DefaultValidityLength).ToShortDateString();
            ucNewAppicationaLicenseInfocs1.lblLicenseFees.Text = LicenseClasses.ClassFees.ToString();
            ucNewAppicationaLicenseInfocs1.lblTotalFees.Text = (Fees + LicenseClasses.ClassFees).ToString();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklableShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(License.ApplicationInfo.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void LinkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new  frmShowLicense(License);
            frm.ShowDialog();
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            // check
            string ErrorMessage = "";

            if(!clsLicense.CanRenewLicense(ref ErrorMessage,License.ExpirationDate,License.IsActive, License.LicenseID))
            {
                MessageBox.Show(ErrorMessage);
            }


            int ApplicationID = clsLocalAppcs.AddNewApplication(License.ApplicationInfo.ApplicantPersonID,
                License.LicenseClass, clsApplication.enApplicationType.RenewDrivingLicenseService, clsApplication.enApplicationStatus.Completed);

           
            if (ApplicationID == -1)
            {
                return;
            }

      


            int NewLicenseID = clsLicense.RenewLicense(License.LicenseID, ApplicationID, License.DriverID, License.LicenseID, DateTime.Now.AddYears(LicenseClasses.DefaultValidityLength),
                LicenseClasses.ClassFees, ucNewAppicationaLicenseInfocs1.txtNotes.Text, clsSystem.CurrentUser.UserID );
            if(NewLicenseID == -1)
            {
                return;
            }

            ucNewAppicationaLicenseInfocs1.lblRenewLicenseID.Text = NewLicenseID.ToString();
            ucNewAppicationaLicenseInfocs1.lblRenewApplicationID.Text = ApplicationID.ToString();
            linkLabelShowLicenseInfo.Enabled = true;
            btnRenew.Enabled = false;
            ucNewAppicationaLicenseInfocs1.txtNotes.Enabled = false;

            MessageBox.Show("Successfully Renewed with the LicenseID" + NewLicenseID);
            License = clsLicense.Find(NewLicenseID);
        }
    }
}
