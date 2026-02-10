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
    public partial class frmPersonDetails : Form
    {
        private clsPerson person;
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            SetPerson(PersonID);
            _LoadPersonData();


        }

        public frmPersonDetails(clsPerson Person)
        {
            InitializeComponent();
            person = Person;
            _LoadPersonData();
        }

        private void Refresh(int PersonID)
        {
            SetPerson(PersonID);
            _LoadPersonData();
        }
        
        private void SetPerson(int PersonID)
        {
            person = clsPerson.FindPersonByID(PersonID);
        }

        private void _LoadPersonData()
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {

        }

        protected string GetFullName(string firstName, string secondName, string thirdname, string lastname)
        {

            return firstName + " " + secondName + " " + thirdname + " " + lastname;
        }


      
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new frmAddEditPerson(int.Parse(lblPersonID.Text));
            frm.ShowDialog();
            Refresh(int.Parse(lblPersonID.Text));
        }
    }
}
