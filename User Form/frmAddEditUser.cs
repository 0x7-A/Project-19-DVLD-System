using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace Project_19_DVDL__2nd_
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew = 0, Edit = 1 };
        private enMode _Mode;
        private clsPerson _CurrentPerson;
        private clsUsers _CurrentUser;

        public frmAddEditUser(int PersonID, int UserID)
        {
            InitializeComponent();

            if (PersonID == -1 || UserID == -1)
            {
                _Mode = enMode.AddNew;
                this.Text = "Add New User";
            }
            else
            {
                _CurrentPerson = clsPerson.FindPersonByID(PersonID);
                _CurrentUser = clsUsers.FindByID(UserID);
                if (_CurrentPerson == null || _CurrentUser == null)
                {
                    MessageBox.Show("Something went wrong");
                    return;
                }

                _Mode = enMode.Edit;
                this.Text = "Update User";
            }

            Check();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Check()
        {
            LoadFilterComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
            }
            else
            {
                lblTitle.Text = "Update User";
                gbFiliter.Enabled = false;
                txtFiliter.Text = _CurrentPerson.PersonID.ToString();
                ucPerson1.LoadPersonInfo(_CurrentPerson.PersonID);
                LoadUserInfo();
            }

        }

        private void LoadUserInfoTab()
        {


        }

        private void btnNext_Click(object sender, EventArgs e)
        {



            if (_CurrentPerson != null)
            {
                if (_Mode == enMode.AddNew && clsUsers.DoesUserExistsWithPersonID(_CurrentPerson.PersonID))
                {
                    MessageBox.Show("Person with ID" + _CurrentPerson.PersonID + " already a User !");
                    return;
                }
                else
                {
                    tcpersonalInfo.SelectedTab = tpageUserInfo;
                }

            }

        }

        private void gbFiliter_Enter(object sender, EventArgs e)
        {

        }

        private void TabControl1_Click(object sender, EventArgs e)
        {

        }

        private void LoadFilterComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("PersonID");
            comboBox1.Items.Add("National No");

            comboBox1.SelectedItem = "PersonID";
        }

        private void tpageUserInfo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadUserInfo()
        {
            lblUserID.Text = _CurrentUser.UserID.ToString();
            txtUserName.Text = _CurrentUser.userName;
            txtPassword.Text = _CurrentUser.password;
            txtConfimPassword.Text = _CurrentUser.password;
            cbIsActive.Checked = _CurrentUser.isActive;

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            Generic_Validating(sender, e, "UserName TextBox");

            if (!e.Cancel)
            {
                if (_Mode == enMode.AddNew || (_Mode == enMode.Edit && _CurrentUser.userName != txtUserName.Text.Trim()))
                {
                    if (clsUsers.DoesUserNameExists(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "This username is already taken by another user!");
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, "");
                    }
                }

            }

        }

        private void Generic_Validating(object sender, CancelEventArgs e, string FeildName)
        {

            TextBox txt = (TextBox)sender;


            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt, $"{FeildName} field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            Generic_Validating(sender, e, "Password TextBox");
        }

        private void txtConfimPassword_Validating(object sender, CancelEventArgs e)
        {
            Generic_Validating(sender, e, "Confirm Password TextBox");

            if (!e.Cancel)
            {
                if (txtConfimPassword.Text != txtPassword.Text)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtConfimPassword, "Pssword  is not matched!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtConfimPassword, "");
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_CurrentPerson == null)
            {
                MessageBox.Show("Make sure to Fill the PersonInfo ");
                return;
            }
            if (_Mode == enMode.AddNew && clsUsers.DoesUserExistsWithPersonID(_CurrentPerson.PersonID))
            {
                MessageBox.Show("Cannot save. This person already has a user account.", "Error");
                return;
            }

            
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fix the validation errors before saving.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_CurrentPerson.PersonID == -1)
            {
                MessageBox.Show("Please select a person first!");
                tcpersonalInfo.SelectedIndex = 0;
                return;
            }
            else if(_Mode == enMode.Edit &&  !_CheckDoesTheUserUpdate())
            {
                MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
                return;
             }


            _Save();


        }

        private void _Save()
        {


          

            if (_Mode == enMode.Edit)
            {
                if (clsUsers.Update(_CurrentUser.UserID, _CurrentUser.PersonID, txtUserName.Text, txtConfimPassword.Text, cbIsActive.Checked))
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }



            }
            else
            {

                int InsertedID = -1;
                if (clsUsers.AddNewUser(ref InsertedID, _CurrentPerson.PersonID, txtUserName.Text, txtConfimPassword.Text, cbIsActive.Checked))
                {
                    lblUserID.Text = InsertedID.ToString();
                    MessageBox.Show($"Successfully Added the New User with ID {InsertedID}");
                    
                    _Mode = enMode.Edit;
                    Check();
                }
                else
                {
                    MessageBox.Show("Something WentWrong while Adding the New User");
                }


            }

        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiliter.Text))
            {
                errorProvider1.SetError(txtFiliter, "Please enter an ID first!");
                return;
            }

            if (comboBox1.SelectedItem == "PersonID")
            {
                if (int.TryParse(txtFiliter.Text.Trim(), out int PersonID))
                {
                    _CurrentPerson = clsPerson.FindPersonByID(PersonID);
                }


            }
            else if (comboBox1.SelectedItem == "National No")
            {
                _CurrentPerson = clsPerson.FindPersonByNationalNo(txtFiliter.Text);

            }

            if (_CurrentPerson == null)
            {
                MessageBox.Show($"No Person with {txtFiliter.Text} PersonID/National Number, try again", "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ucPerson1.LoadPersonInfo(_CurrentPerson.PersonID);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
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
                ucPerson1.LoadPersonInfo(PersonID);
                txtFiliter.Text = PersonID.ToString();
            }

        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {

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

        private void txtFiliter_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtFiliter, "");

            
            if (comboBox1.Text == "PersonID")
            {
               
                if (!int.TryParse(txtFiliter.Text.Trim(), out _) && !string.IsNullOrWhiteSpace(txtFiliter.Text))
                {
                    e.Cancel = true; 
                    errorProvider1.SetError(txtFiliter, "Numbers only for Person ID!");
                }
            }
        }


        private bool _CheckDoesTheUserUpdate()
        {
            return (_CurrentUser.userName != txtUserName.Text || _CurrentUser.isActive != cbIsActive.Checked || _CurrentUser.password != txtConfimPassword.Text ) ;
        }

    }
}
