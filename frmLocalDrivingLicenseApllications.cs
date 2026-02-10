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
    public partial class frmLocalDrivingLicenseApplications : Form
    {

        private DataTable _dt;
        public frmLocalDrivingLicenseApplications()
        {
            InitializeComponent();
            _Refersh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {

        }

        private void _Refersh()
        {
            _dt = clsLocalAppcs.GetllApplications();
            dataGridView1.DataSource = _dt;
            lblrecord.Text = _dt.Rows.Count.ToString();
            LoadComboBoxFilter();

        }


        private void LoadComboBoxFilter()
        {
            comboBox1.Items.Clear();


            comboBox1.Items.Add("None");
            comboBox1.Items.Add("L.D.L.AppID");
            comboBox1.Items.Add("National No.");
            comboBox1.Items.Add("Full Name");
            comboBox1.Items.Add("Status");



            comboBox1.SelectedIndex = 0;
            txtFiliter.Visible = false;
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "None")
            {

                txtFiliter.Visible = false;
                return;
            }


            txtFiliter.Visible = true;


        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";


            switch (comboBox1.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "L.D.L.AppID";
                    break;
                case "National No.":
                    FilterColumn = "National No.";
                    break;
                case "Full Name":
                    FilterColumn = "Full Name";
                    break;
                case "Status":
                    FilterColumn = "Status";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFiliter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dt.DefaultView.RowFilter = "";

            }
            else if (FilterColumn == "L.D.L.AppID")
            {

                if (int.TryParse(txtFiliter.Text.Trim(), out int ID))
                {
                    _dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, ID);
                }
            }
            else
            {

                _dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFiliter.Text.Trim());
            }


            lblrecord.Text = _dt.DefaultView.Count.ToString();
        }

        private void txtFiliter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (comboBox1.Text == "L.D.L.AppID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void writtenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest(GetSelectedLDLAppID(), clsApplication.enTestType.Written);
            frm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmNewLDLApplication frm = new frmNewLDLApplication();
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {


            string status = dataGridView1.CurrentRow.Cells["Status"].Value.ToString().Trim();
            int PassedTests = int.Parse(dataGridView1.CurrentRow.Cells["Passed Tests"].Value.ToString().Trim());

            if (status == "New")
            {
                cancleApplictionToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;


                cmSechduleTestsToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = true;
                cmIssueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;

                EnableTestType(PassedTests);


                if (PassedTests > 0)
                {
                    deleteApplicationToolStripMenuItem.Enabled = false;
                }
                if (PassedTests == 3)
                {
                    cmIssueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                }

            }
            else if (status == "Canclled")
            {
                cancleApplictionToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cmSechduleTestsToolStripMenuItem.Enabled = false;


                cmIssueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = false;

            }
            else if (status == "Completed")
            {

                cancleApplictionToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cmSechduleTestsToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = false;
                cmIssueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                showLicenseToolStripMenuItem.Enabled = true;
            }




        }





        private void EnableTestType(int passedTest)
        {

            switch (passedTest)
            {
                case 0:

                    visionTestToolStripMenuItem.Enabled = true;
                    streetTestToolStripMenuItem.Enabled = false;
                    writtenTestToolStripMenuItem.Enabled = false;
                    break;


                case 1:
                    visionTestToolStripMenuItem.Enabled = false;
                    writtenTestToolStripMenuItem.Enabled = true;
                    streetTestToolStripMenuItem.Enabled = false;
                    break;

                case 2:
                    visionTestToolStripMenuItem.Enabled = false;
                    writtenTestToolStripMenuItem.Enabled = false;
                    streetTestToolStripMenuItem.Enabled = true;
                    break;


            }



        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsLocalAppcs.DeleteLDLApp(GetSelectedLDLAppID(), GetPersonID(), GetClassLicenseID()))
            {
                MessageBox.Show("succeefully Deleted");
                _Refersh();
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

        }


        private int GetSelectedLDLAppID()
        {
            return int.Parse(dataGridView1.CurrentRow.Cells["L.D.L.AppID"].Value.ToString().Trim()); ;
        }

        private int GetPersonID()
        {
            return clsPerson.FindPersonByNationalNo(dataGridView1.CurrentRow.Cells["National No."].Value.ToString().Trim()).PersonID;
        }
        private string GetNationalNo()
        {
            return dataGridView1.CurrentRow.Cells["National No."].Value.ToString().Trim();
        }

        private int GetClassLicenseID()
        {
            return clsLicenseClasses.GetClassLicenseIDUseingClassName(dataGridView1.CurrentRow.Cells["Driving Class"].Value.ToString().Trim());

        }

        private void cancleApplictionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsLocalAppcs.UpdateToCancelled(GetPersonID(), GetClassLicenseID()))
            {
                MessageBox.Show("Updated sucessfully");
                _Refersh();

            }
            else
            {
                MessageBox.Show("Something went wrong while updating");
            }


        }

        private void showLicenseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmShowLicense frm = new frmShowLicense(GetSelectedLDLAppID(), GetNationalNo());
            frm.ShowDialog();
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest(GetSelectedLDLAppID(), clsApplication.enTestType.Vision);
            frm.ShowDialog();
        }

        private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest(GetSelectedLDLAppID(), clsApplication.enTestType.Street);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLicenseHistory frm = new frmLicenseHistory(GetPersonID());
            frm.ShowDialog();
        }

        private void cmIssueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDrivingLicenseForTheFirstTime frm = new frmIssueDrivingLicenseForTheFirstTime(GetSelectedLDLAppID(),GetPersonID());
            frm.ShowDialog();
            _Refersh();

        }
    }
}
