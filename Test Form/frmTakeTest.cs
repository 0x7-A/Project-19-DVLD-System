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

namespace Project_19_DVDL__2nd_
{
    public partial class frmTakeTest : Form
    {
        clsLocalAppcs _LDL;
        clsTestTypes _TestTypes;
        clsApplication.enTestType TestTypeEnum;
        int _AppointmentID = -1;
        clsAppointments Appointment;
        public frmTakeTest(int AppointmentID)
        {
            InitializeComponent();
         
            _AppointmentID = AppointmentID;
            LoadInfo();
            changeTitleAndPicture();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetFllName()
        {
            clsPerson person = clsPerson.FindPersonByID(_LDL.APPLICATION.ApplicantPersonID);
            if (person != null)
            {
                return person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            }

            return "";
        }

        private void changeTitleAndPicture()
        {
            if (TestTypeEnum == clsApplication.enTestType.Vision)
            {
                ucTakeTest1.gbTest.Text = "Vision Test";
                ucTakeTest1.pbTestType.Image = Resources.Vision_512;
            }
            else if (TestTypeEnum == clsApplication.enTestType.Written)
            {
                ucTakeTest1.gbTest.Text = "Written Test";
                ucTakeTest1.pbTestType.Image = Resources.Written_Test_512;
            }
            else
            {
                ucTakeTest1.gbTest.Text = "Street Test";
                ucTakeTest1.pbTestType.Image = Resources.Street_Test_32;
            }

        }

        private void LoadInfo()
        {

             Appointment = clsAppointments.Find(_AppointmentID);

            if (Appointment != null)
            {

                _LDL = clsLocalAppcs.FindByLocalDrivingAppID(Appointment.LocalDrivingLicenseApplicationID);
                TestTypeEnum = Appointment.TestTypeID;
                _TestTypes = clsTestTypes.FindTestType((int)TestTypeEnum);

                if(_TestTypes == null || _LDL == null)
                {
                    return;
                }

                ucTakeTest1.lblDate.Text = Appointment.AppointmentDate.ToString();
                ucTakeTest1.lblLDLAppID.Text = _LDL.LocalDrivingLicenseApplicationID.ToString();
                ucTakeTest1.lblDclass.Text = _LDL.LicenseClassName.ToString();
                ucTakeTest1.lblTrial.Text = clsTest.GetTotalTrials(_LDL.LocalDrivingLicenseApplicationID, TestTypeEnum).ToString();
                ucTakeTest1.lblFees.Text = Appointment.PaidFees.ToString();
                ucTakeTest1.lblName.Text = GetFllName();
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            int Result = clsTest.AddNewTest(_AppointmentID, rbPass.Checked, txtNotes.Text, clsSystem.CurrentUser.UserID);
            if (Result != -1)
            {
                
                clsAppointments.UpdateIsLockedToFalse(_AppointmentID);

                btnSave.Enabled = false; 
                ucTakeTest1.lblTestID.Text =  Result.ToString();
           
                MessageBox.Show("Data Saved Sucessfully ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInfo();
            }
            else
            {
           
                MessageBox.Show("Somthig went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        

    }
}
