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
    public partial class frmInternationalLicenseApplication : Form
    {

        clsLicense License;
        decimal Fees = -1;
        int InternationalAppID = -1;
        public frmInternationalLicenseApplication()
        {
            InitializeComponent();

        }

      

        private void Check()
        {
            string any = "";

            clsManageAppTypes.GetApplicationFeesAndDescription((int)clsApplication.enApplicationType.NewInternationalLicense, ref Fees, ref any);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void pbFibdLicenseID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;


            License = clsLicense.Find(int.Parse(textBox1.Text));

            if (License == null)
            {
                MessageBox.Show("License not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssue.Enabled = false;
                return;
            }


            Check();


            ucDriverLicenseInfo1.Load(License);

            linklableShowLicenseHistory.Enabled = true;
            FillApplicationInfo();
            btnIssue.Enabled = true;

        }

        private void FillApplicationInfo()
        {

            ucInternationalApplicationInfo1.lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            ucInternationalApplicationInfo1.lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            ucInternationalApplicationInfo1.lblFees.Text = Fees.ToString();
            ucInternationalApplicationInfo1.lblIssueDate.Text = DateTime.Now.ToShortDateString();
            ucInternationalApplicationInfo1.lblCreatedBy.Text = clsSystem.CurrentUser.userName;
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

        private void btnIssue_Click(object sender, EventArgs e)
        {
            string Message = "";
            if (!clsLicense.CanIssueInternationalLicense(ref Message, License))
            {
                MessageBox.Show(Message);
                return;
            }

            int NewAppID = -1;



            if (clsInternationalLicense.AddNewInternationalApplication(ref NewAppID, ref InternationalAppID, License.ApplicationInfo.ApplicantPersonID, Fees, clsSystem.CurrentUser.UserID,
               License.DriverID, int.Parse(textBox1.Text), License.ExpirationDate))
            {
                ucInternationalApplicationInfo1.lblInternationalLicenseID.Text = InternationalAppID.ToString();
                ucInternationalApplicationInfo1.lblInternationalApplicationID.Text = NewAppID.ToString();

                MessageBox.Show("Succefully Added an Internation License ID: " + InternationalAppID);
                LinkLabelShowLicenseInfo.Enabled = true;
                btnIssue.Enabled = false;

            }
        }

        private void LinkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalDriverLicenseInfo frm = new frmInternationalDriverLicenseInfo(InternationalAppID);
            frm.ShowDialog();
        }
    }
}
