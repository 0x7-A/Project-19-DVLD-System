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
    public partial class ucScheduledTest : UserControl
    {
        clsApplication.enTestType TestTypeEnum;
        clsLocalAppcs _LDL;
        clsTestTypes _TestTypes;
        bool isRetake;
        int _AppointmentID = -1;

        public enum enMode { AddNew = 0, Update = -1 }
        enMode _Mode;

        public ucScheduledTest()
        {
            InitializeComponent();
        }

        public void SetInfo(int LocalDrivingLicenseApplicationID, clsApplication.enTestType TestType)
        {
            _Mode = enMode.AddNew;

            _LDL = clsLocalAppcs.FindByLocalDrivingAppID(LocalDrivingLicenseApplicationID);
            TestTypeEnum = TestType;
            _TestTypes = clsTestTypes.FindTestType((int)TestType);


            if (_LDL == null || _TestTypes == null)
            {
                MessageBox.Show("Error: Could not find Application data.");
                return;
            }


            Check();
        }

        public ucScheduledTest(clsLocalAppcs LDL, clsApplication.enTestType testType)
        {
            InitializeComponent();

            TestTypeEnum = testType;
            _LDL = LDL;
            _TestTypes = clsTestTypes.FindTestType((int)testType);

            if (_LDL == null || _TestTypes == null)
            {
                return;
            }
            Check();
        }

        public void LoadData(int AppointmentID)
        {
            _Mode = enMode.Update;
            _AppointmentID = AppointmentID;

            clsAppointments Appointment = clsAppointments.Find(_AppointmentID);

            if (Appointment != null)
            {

                _LDL = clsLocalAppcs.FindByLocalDrivingAppID(Appointment.LocalDrivingLicenseApplicationID);
                TestTypeEnum = Appointment.TestTypeID;
                _TestTypes = clsTestTypes.FindTestType((int)TestTypeEnum);

                changeTitleAndPicture();
                FillDLDAppInfo();
                FillTestTypeInfo();

                // 3. تحديث بيانات الموعد المحددة
                dateTimePicker1.Value = Appointment.AppointmentDate;
                lblTestID.Text = Appointment.TestAppointmentID.ToString();

                if (Appointment.IsLocked)
                {
                    btnSave.Enabled = false;
                    dateTimePicker1.Enabled = false;
                }
                if (Appointment.RetakeTestApplicationID != -1)
                {
                    ucRetakeTest1.Visible = true;

                }
            }
        }


        private void Check()
        {
            isRetake = clsTest.NeedsRetakeTest(_LDL.LocalDrivingLicenseApplicationID, TestTypeEnum);

            if (isRetake)
            {
                decimal retakeFees = 0;
                string Message = "";
                if (!clsManageAppTypes.GetApplicationFeesAndDescription((int)clsApplication.enApplicationType.RetakeTest, ref retakeFees, ref Message))
                {
                    return;
                }

                ucRetakeTest1.Load(retakeFees, _TestTypes.TestTypeFee);
               
                ucRetakeTest1.Enabled = true;

            }
            else
            {
                ucRetakeTest1.Enabled = false;
            }


            changeTitleAndPicture();
            FillDLDAppInfo();
            FillTestTypeInfo();
            lblTrial.Text = clsTest.GetTotalTrials(_LDL.LocalDrivingLicenseApplicationID, TestTypeEnum).ToString(); // method get the count of test
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);

        }


        private void changeTitleAndPicture()
        {
            if (TestTypeEnum == clsApplication.enTestType.Vision)
            {
                gbTest.Text = "Vision Test";
                pbTestType.Image = Resources.Vision_512;
            }
            else if (TestTypeEnum == clsApplication.enTestType.Written)
            {
                gbTest.Text = "Written Test";
                pbTestType.Image = Resources.Written_Test_512;
            }
            else
            {
                gbTest.Text = "Street Test";
                pbTestType.Image = Resources.Street_Test_32;
            }

        }

        private void FillDLDAppInfo()
        {
            lblLDLAppID.Text = _LDL.LocalDrivingLicenseApplicationID.ToString();
            lblDclass.Text = _LDL.LicenseClassName;


        }

        private void FillTestTypeInfo()
        {
            lblFees.Text = _TestTypes.TestTypeFee.ToString();
            lblName.Text = GetFllName();
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

        public void SetTestID(int testID)
        {
            lblTestID.Text = testID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.AddNew)
            {
                int RetakeAppID = -1;


                if (isRetake)
                {
                    decimal retakeFees = 0;
                    string description = "";
                    clsManageAppTypes.GetApplicationFeesAndDescription((int)clsApplication.enApplicationType.RetakeTest, ref retakeFees, ref description);

                    RetakeAppID = clsLocalAppcs.AddNewApplication(_LDL.APPLICATION.ApplicantPersonID, clsSystem.CurrentUser.UserID, clsApplication.enApplicationType.RetakeTest,
                        clsApplication.enApplicationStatus.Completed);

                    if (RetakeAppID == -1) return;
                    else ucRetakeTest1.SetRetakeApplicationID(RetakeAppID);

                }


                _AppointmentID = clsAppointments.AddTestAppointment(TestTypeEnum, _LDL.LocalDrivingLicenseApplicationID, dateTimePicker1.Value,
                                    _TestTypes.TestTypeFee, RetakeAppID);
            }
            else
            {

                if (clsAppointments.UpdateDate(_AppointmentID, dateTimePicker1.Value))
                {
                }
                else
                {
                    _AppointmentID = -1;
                }
            }

            if (_AppointmentID != -1)
            {
                lblTestID.Text = _AppointmentID.ToString();
                _Mode = enMode.Update;
                btnSave.Enabled = false;
                MessageBox.Show("Data Saved Suceesfully");
            }
            else
            {
                MessageBox.Show("somthing went wrong");
            }

        }

        private void gbTest_Enter(object sender, EventArgs e)
        {

        }

        private void ucRetakeTest1_Load(object sender, EventArgs e)
        {

        }

    }
}
