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
    public partial class ucPersonWithFilter : UserControl
    {


        private void ucPersonWithFilter_Load(object sender, EventArgs e)
        {

        }

        clsPerson person;
        public clsPerson _CurrentPerson;
        private clsUsers _CurrentUser;



        public ucPersonWithFilter()
        {
            InitializeComponent();
            Check();
        }

        public ucPersonWithFilter(int PersonID)
        {
            InitializeComponent();
            if (PersonID != -1)
            {

            }
            else
            {

            }
            Check();
        }

        public void LoadPersonInfo(int PersonID)
        {
            person = clsPerson.FindPersonByID(PersonID);
            LoadPersonInfoWithObject(person);
        }


        private void Check()
        {
            LoadFilterComboBox();



        }

        public void LoadPersonInfoWithObject(clsPerson person)
        {


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

        private void linkLabel1_LinkClickeds(object sender, EventArgs e)
        {

            Form frm = new frmAddEditPerson(int.Parse(lblPersonID.Text));
            frm.ShowDialog();
            LoadPersonInfo(int.Parse(lblPersonID.Text));
        }

        private void pbFind_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiliter.Text))
            {
                return;
            }

            if (comboBox1.SelectedItem == "PersonID")
            {
                _CurrentPerson = clsPerson.FindPersonByID(int.Parse(txtFiliter.Text));

            }
            else
            {
                _CurrentPerson = clsPerson.FindPersonByNationalNo(txtFiliter.Text);
            }

            if (_CurrentPerson == null)
            {
                MessageBox.Show("Error: Person not found.");

                return;
            }

            LoadPersonInfoWithObject(_CurrentPerson);


        }

        private void LoadFilterComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("PersonID");
            comboBox1.Items.Add("National No");

            comboBox1.SelectedItem = "PersonID";
        }

        private void txtFiliter_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (comboBox1.Text == "PersonID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void pbCreateNewPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.DataBack += GetPersonID_DataBack;
            frm.ShowDialog();
        }

 
        private void GetPersonID_DataBack(object sender, int PersonID)
        {
            _CurrentPerson = clsPerson.FindPersonByID(PersonID);

            if (_CurrentPerson != null)
            {
                LoadPersonInfo(PersonID);
                txtFiliter.Text = PersonID.ToString();
            }

        }


    }
}
