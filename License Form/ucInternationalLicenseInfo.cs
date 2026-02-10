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
    public partial class ucInternationalLicenseInfo : UserControl
    {
        private clsPerson Person;
        private clsInternationalLicense InternationalLicense;

        public ucInternationalLicenseInfo()
        {
            InitializeComponent();
        }



        private void label12_Click(object sender, EventArgs e)
        {

        }

        public void LoadInfo(int InternationalLicenseID)
        {
            InternationalLicense = clsInternationalLicense.GetInternationalLicenseInfo(InternationalLicenseID);

            if (InternationalLicense == null) {
                return;
            }
            Person = clsPerson.FindPersonByID(InternationalLicense.ApplicantPersonID);

            if (Person == null)
            {
                return;
            }
            FillPersonInfo();
            FillInternationLicenseInfo();
        }

        private void FillInternationLicenseInfo()
        {
            lblApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            lblDriverID.Text = InternationalLicense.DriverID.ToString();
            lblExpirationDate.Text = InternationalLicense.ExpirationDate.ToShortDateString();
            lblInternationalLicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            lblIsActive.Text = InternationalLicense.IsActive ? "Yes" : "No";
            lblLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblIssueDate.Text = InternationalLicense.IssueDate.ToShortDateString();
        }

        private void FillPersonInfo()
        {
            lblName.Text = GetFullName();
            lblNationalNo.Text = Person.NationalNumber;
            lblDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            SetGendeAndPicture();
        }

        private string GetFullName()
        {
            return Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
        }

        private void SetGendeAndPicture()
        {

            if (Person.Gendor == 0)
            {
                lblGender.Text = "Male";
                pbGender.Image = Resources.Man_32;
                pbPerson.Image = Resources.Male_512;
            }
            else
            {
                lblGender.Text = "Female";
                pbGender.Image = Resources.Woman_32;
                pbPerson.Image = Resources.Female_512;
            }

            if (!string.IsNullOrEmpty(Person.ImagePath))
            {
                if (System.IO.File.Exists(Person.ImagePath))
                {
                    pbPerson.Load(Person.ImagePath);
                }
            }

        }


    }
}
