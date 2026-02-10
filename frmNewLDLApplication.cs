
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project19_businessLayer;

namespace Project_19_DVDL__2nd_
{
    public partial class frmNewLDLApplication : Form
    {
        public frmNewLDLApplication()
        {
            InitializeComponent();
            SetAppInfo();
        }
        DataTable dt;


        private void SetAppInfo()
        {
            lblDateTime.Text = DateTime.Now.ToString("d");
            lblApplicationFees.Text = clsSystem.NewApplicationsFees.ToString();
            lblCreatedBy.Text = clsSystem.CurrentUser.userName;
            LoadLicenseClassesComborBox();
        }

        private void LoadLicenseClassesComborBox()
        {
            comboBox1.Items.Clear();
            dt = clsLicenseClasses.GetLicenseIDAndClassName();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ClassName";
            comboBox1.ValueMember = "LicenseClassID";

            comboBox1.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private int GetSelectedClass()
        {
            return int.Parse(comboBox1.SelectedValue.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ucPersonWithFilter1._CurrentPerson == null)
            {
                MessageBox.Show("Please Make sure you linked the application with persson", "Error");
                return;


            }
            int AppLID = -1;
            if (clsLocalAppcs.CheckFromPreviousApp(ref AppLID, ucPersonWithFilter1._CurrentPerson.PersonID, GetSelectedClass()))
            {
                MessageBox.Show("Can not have an more than one App with the same license class  and New Status, Preivous LDLID:  " + AppLID);
                return;
            }

            int LDLAppID = clsLocalAppcs.AddNewLDLApp(ucPersonWithFilter1._CurrentPerson.PersonID, clsSystem.CurrentUser.UserID, GetSelectedClass());

            if (LDLAppID == -1)
            {
                MessageBox.Show("Something went wrong, please try later");
                return;
            }

            lblDLAID.Text = LDLAppID.ToString();
            MessageBox.Show("Succefully added new LDL APP with ID" + LDLAppID);

        }

        private void frmNewLDLApp_ication_Load(object sender, EventArgs e)
        {

        }


    }
}
