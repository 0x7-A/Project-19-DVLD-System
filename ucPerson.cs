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
    public partial class ucPerson : UserControl
    {
        clsPerson person;
        public ucPerson()
        {
            InitializeComponent();
        }

        public ucPerson(int PersonID)
        {
            InitializeComponent();
            LoadPersonInfo(PersonID);
        }

        public void LoadPersonInfo(int PersonID)
        {
            person = clsPerson.FindPersonByID(PersonID);
            LoadPersonInfoWithObject(person);
        }


        public void LoadPersonInfoWithObject(clsPerson person)
        {

            if (person == null)
            {
                MessageBox.Show("Error: Person not found.");

                return;
            }


            lblPersonID.Text = person.PersonID.ToString();
            lblName.Text = GetFullName(person.FirstName, person.SecondName, person.ThirdName, person.LastName);
            lblNationalNo.Text = person.NationalNumber;
            lblEmail.Text = person.Email;
            lblAddress.Text = person.Address;
            lblPhone.Text = person.Phone;
            lblDateOfBirth.Text = person.DateOfBirth.ToString();

            if (person.Gendor == 0)
            {
                lblGender.Text = "Male";
                pbGender.Image = Resources.Man_32;

            }
            else
            {
                lblGender.Text = "Female";
                pbGender.Image = Resources.Woman_32;
            }

            lblCountryName.Text = person.CountryName;

            if (File.Exists(person.ImagePath))
            {
                PBPersonImage.ImageLocation = person.ImagePath;
            }
        }

        public string GetFullName(string firstName, string secondName, string thirdname, string lastname)
        {
            return firstName + " " + secondName + " " + thirdname + " " + lastname;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddEditPerson(int.Parse(lblPersonID.Text));
            frm.ShowDialog();
            LoadPersonInfo(int.Parse(lblPersonID.Text));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
