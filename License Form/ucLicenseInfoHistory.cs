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
    public partial class ucLicenseInfoHistory : UserControl
    {
        private clsPerson _person ;
        private clsLicense _License ;
        

        public ucLicenseInfoHistory()
        {
            InitializeComponent();
        }



        public void LoadInfos(clsLicense L)
        {
            _License = L;
            _person = clsPerson.FindPersonByID(_License.ApplicationInfo.ApplicantPersonID);
            LoadPersinInfo();
            LoadLicenseInfo();
        }

        public void LoadInfos(clsPerson person, clsLicense L)
        {
            _person = person;
            _License = L;
            LoadPersinInfo();
            LoadLicenseInfo();
        }
        private void LoadPersinInfo()
        {
            lblName.Text = GetFullName();
            lblNationalNo.Text = _person.NationalNumber;

            lblDateOfBirth.Text = GetStringDate(_person.DateOfBirth);
            SetImageAndGender();


        }

        private void LoadLicenseInfo()
        {
            lblDriverID.Text = _License.DriverID.ToString();
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblIsActive.Text = _License.IsActive.ToString();
            lblIssueDate.Text = _License.IssueDate.ToString();
            lblNotes.Text = _License.Notes.ToString();
            lblIssueReason.Text = _License.IssueReason;
            lblExpirationDate.Text = _License.ExpirationDate.ToString();
            lblClass.Text =  clsLicenseClasses.GetClassNameUsingClassLID(_License.LicenseClass);
        }


        private string GetFullName()
        {
            return _person.FirstName + " " + _person.SecondName + " " +_person.ThirdName + " " + _person.LastName;
        }

        private string GetStringDate(DateTime dt)
        {
            return dt.Day + "/" + dt.Month.ToString() + "/" + dt.Year;
        }

        private void SetImageAndGender()
        {
            if (!string.IsNullOrEmpty(_person.ImagePath))
            {
                pbPersonImage.Image = Image.FromFile(_person.ImagePath);


            }
            else
            {

                if (_person.Gendor == 0)
                {
                    pbPersonImage.Image = Resources.Male_512;
                }
                else
                {
                    pbPersonImage.Image = Resources.Female_512;
                }

            }


            if (_person.Gendor == 0)
            {
                lblGender.Text = "Male";
                pbGender.Image = Resources.Man_32;
            }
            else
            {
                lblGender.Text = "Female";
                pbGender.Image = Resources.Woman_32;

            }

        }

        private void ucLicenseInfo_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
