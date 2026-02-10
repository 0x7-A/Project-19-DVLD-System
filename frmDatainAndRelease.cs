using Project_19_DVDL__2nd_.Properties;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_19_DVDL__2nd_
{
    public partial class frmDatainAndRelease : Form
    {
        public enum enMode { Detain = 0, Release = 1 }
        private clsDetainLicense.enMode _Mode;
        private clsLicense License;
        private Decimal ApplicationFees;
        private clsDetainLicense Detained;
        public frmDatainAndRelease(clsDetainLicense.enMode Mode)
        {
            InitializeComponent();
            _Mode = Mode;
            Check();
            pbFibdLicenseID_Click_1(null, null);
        }

        public frmDatainAndRelease(clsDetainLicense.enMode Mode, int LicenseID)
        {
            InitializeComponent();
            _Mode = Mode;
            gbFilter.Enabled = false;
            textBox1.Text = LicenseID.ToString();
            Check();
        }

        private void Check()
        {
            if (_Mode == clsDetainLicense.enMode.Release)
            {
                lblTitile.Text = "Release Detained License";
                ucDetainInfo1.Visible = false;
                ucReleaseLicenseInfo1.Visible = true;
                pbDetainRelease.Image = Resources.Release_Detained_License_64;
                btnIssueReplacement.Text = "Release";

                ucReleaseLicenseInfo1.lblCreatedBy.Text = clsSystem.CurrentUser.userName;
            }
            else
            {
                lblTitile.Text = "Detain License";
                ucDetainInfo1.Visible = true;
                ucReleaseLicenseInfo1.Visible = false;
                pbDetainRelease.Image = Resources.Detain_32;
                btnIssueReplacement.Text = "Detain";

                ucDetainInfo1.lblCreatedBy.Text = clsSystem.CurrentUser.userName;
                ucDetainInfo1.lblDetainDate.Text = DateTime.Now.ToShortDateString();

            }

        }

        private void pbFibdLicenseID_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;


            License = clsLicense.Find(int.Parse(textBox1.Text));


            if (License == null)
            {
                MessageBox.Show("License not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }

            linklableShowLicenseHistory.Enabled = true;

            gbFilter.Enabled = false;

            if (_Mode == clsDetainLicense.enMode.Detain && License.IsDetained)
            {
                MessageBox.Show("Selected License is already detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }


            if (_Mode == clsDetainLicense.enMode.Release && !License.IsDetained)
            {
                MessageBox.Show("Selected License is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }





            ucDriverLicenseInfo1.Load(License);


            btnIssueReplacement.Enabled = true;
            FillInfoAfterFindLicenseObj();
        }


        private void FillInfoAfterFindLicenseObj()
        {
            if (_Mode == clsDetainLicense.enMode.Detain)
            {
                ucDetainInfo1.lblLicenseID.Text = textBox1.Text;
                ucDetainInfo1.txtFineFees.Enabled = true;

                string any = "";
                if (clsManageAppTypes.GetApplicationFeesAndDescription((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense, ref ApplicationFees, ref any))
                {
                    ucReleaseLicenseInfo1.lblApplicationFees.Text = ApplicationFees.ToString();

                }
            }
            else
            {

                Detained = clsDetainLicense.FindByLicenseID(int.Parse(textBox1.Text));

                if (Detained == null)
                {
                    MessageBox.Show("Could not find the detained Info ");
                    return;
                }

                if (Detained.IsReleased)
                {
                    MessageBox.Show("Already realsed with Release ID: " + Detained.IsReleased);
                    return;
                }
                string any = "";
                if (clsManageAppTypes.GetApplicationFeesAndDescription((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense, ref ApplicationFees, ref any))
                {
                    ucReleaseLicenseInfo1.lblApplicationFees.Text = ApplicationFees.ToString();
                }
                else
                {
                    ApplicationFees = 0;
                }


                ucReleaseLicenseInfo1.lblFineFees.Text = Detained.FineFees.ToString();
                ucReleaseLicenseInfo1.lblTotalFees.Text = (Detained.FineFees + ApplicationFees).ToString();


                ucReleaseLicenseInfo1.lblCreatedBy.Text = Detained.CreatedByUserID.ToString();
                ucReleaseLicenseInfo1.lblFineFees.Text = Detained.FineFees.ToString();
                ucReleaseLicenseInfo1.lblTotalFees.Text = (Detained.FineFees + ApplicationFees).ToString();
                ucReleaseLicenseInfo1.lblDetainDate.Text = Detained.DetainDate.ToShortDateString();
                ucReleaseLicenseInfo1.lblDetainID.Text = Detained.DetainID.ToString();

            }
            ucReleaseLicenseInfo1.lblLicenseID.Text = textBox1.Text;


            //  ucReleaseLicenseInfo1.lblTotalFees.Text = (ApplicationFees + clsSystem.NewApplicationsFees).ToString();


        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


       

        private void linkLabelShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(License);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (_Mode == clsDetainLicense.enMode.Detain && string.IsNullOrEmpty(ucDetainInfo1.txtFineFees.Text))
            {
                MessageBox.Show("Please enter Fine Fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ApplicationID = -1;
            int DetainID = (Detained != null) ? Detained.DetainID : -1;

            decimal Fees = (_Mode == clsDetainLicense.enMode.Detain) ?
                    Convert.ToDecimal(ucDetainInfo1.txtFineFees.Text) : ApplicationFees;

            if (clsDetainLicense.Save(_Mode, License, ref ApplicationID, ref DetainID, Fees))
            {
                License.IsDetained = (_Mode == clsDetainLicense.enMode.Detain);
                btnIssueReplacement.Enabled = false;
                gbFilter.Enabled = false;
                linkLabelShowLicenseInfo.Enabled = true;


                if (_Mode == clsDetainLicense.enMode.Release)
                {
                    ucReleaseLicenseInfo1.lblReleaseApplicationID.Text = ApplicationID.ToString();

                    MessageBox.Show("Succfully Realsed with application releasse ID " + ApplicationID);


                }
                else
                {
                    ucDetainInfo1.lblDetainID.Text = DetainID.ToString();
                    ucDetainInfo1.txtFineFees.Enabled = false;
                    MessageBox.Show("Succfully Detained with Detain ID " + DetainID);
                }


            }





        }


        

        private void linklableShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(License);
            frm.ShowDialog();
        }





    }
}
