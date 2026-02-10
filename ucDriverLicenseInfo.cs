using Project_19_DVDL__2nd_.Properties;
using Project19_businessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_19_DVDL__2nd_
{
    public partial class ucDriverLicenseInfo : UserControl
    {
       clsLicense License;
        clsPerson Person; 


        

        public ucDriverLicenseInfo()
        {
            InitializeComponent();

        }

        public  void Load(clsLicense license)
        {
            License = license;
            Person = clsPerson.FindPersonByID(License.ApplicationInfo.ApplicantPersonID);


            if (Person == null || License == null)
            {
                return;
            }

            FillPersonInfo();
            FillLicenseInfo();
        }
        private  void FillLicenseInfo()
        {
            if (License.ApplicationInfo.ApplicationTypeID == 3)
            {
                lblClassName.Text = "Class 3 - Ordinary driving license";
            }

            lblDriverID.Text = License.DriverID.ToString();
            lblExpirationDate.Text = License.ExpirationDate.ToString();
            lblIsActive.Text = License.IsActive ? "Yes" : "No";
            lblIssueDate.Text = License.IssueDate.ToString();
            lblLicenseID.Text = License.LicenseID.ToString();
            lblNotes.Text = License.Notes.ToString();
            lblIsDetained.Text = License.IsDetained ? "Yes" : "No";
            lblIssueReason.Text = License.IssueReason;

        }



        private void  FillPersonInfo()
        {
            lblName.Text = GetFullName();
            lblNationalNo.Text = Person.NationalNumber;
            lblDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            SetGendeAndPicture();
        }

        private string GetFullName()
        {
            return Person.FirstName + " " + Person.SecondName +  " " +  Person.ThirdName + " " + Person.LastName ;
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
