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
    public partial class frmManageDetainedLicense : Form
    {

        private DataTable _dt;
        public frmManageDetainedLicense()
        {
            InitializeComponent();
            RefreshData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDatainAndRelease frm = new frmDatainAndRelease(clsDetainLicense.enMode.Release);
            frm.ShowDialog();
        }

        private void pbAddNewInternationalLicense_Click(object sender, EventArgs e)
        {

            frmDatainAndRelease frm = new frmDatainAndRelease(clsDetainLicense.enMode.Detain);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RefreshData()
        {
            _dt = clsDetainLicense.GetAllDetainedLicenses();
            if (_dt == null)
            {
                return;
            }
            dataGridView1.DataSource = _dt;
            lblrecord.Text = dataGridView1.RowCount.ToString();

            LoadComboBox();

        }

        private void LoadComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("None");
            comboBox1.Items.Add("Detain ID");
            comboBox1.Items.Add("Is Released");
            comboBox1.Items.Add("National No.");
            comboBox1.Items.Add("Full Name");
            comboBox1.Items.Add("Release App.ID");

            comboBox1.SelectedIndex = 0;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            releaseDetainedLicenseToolStripMenuItem.Enabled = !(bool)dataGridView1.CurrentRow.Cells["IsReleased"].Value;
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                frmPersonDetails frm = new frmPersonDetails(clsPerson.FindPersonByNationalNo(
                    (string)dataGridView1.CurrentRow.Cells["N.No."].Value));
                frm.ShowDialog();
            }
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                clsLicense license = clsLicense.Find((int)dataGridView1.CurrentRow.Cells["L.ID"].Value);
                if (license == null)
                {
                    return;
                }
                frmShowLicense frm = new frmShowLicense(license);
                frm.ShowDialog();
            }
        }

        private void showPersonHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                frmLicenseHistory frm = new frmLicenseHistory(clsPerson.FindPersonByNationalNo(
                    (string)dataGridView1.CurrentRow.Cells["N.No."].Value).PersonID);
                frm.ShowDialog();
            }
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                frmDatainAndRelease frm = new frmDatainAndRelease(clsDetainLicense.enMode.Release, (int)dataGridView1.CurrentRow.Cells["L.ID"].Value);
                frm.ShowDialog();
                RefreshData();
            }

        }

        private void txtFiliter_TextChanged(object sender, EventArgs e)
        {


            string FilterColumn = "";

            switch (comboBox1.Text)
            {
                case "Detain ID": FilterColumn = "D.ID"; break;
                case "National No.": FilterColumn = "N.No."; break;
                case "Full Name": FilterColumn = "FullName"; break;
                case "Release App.ID": FilterColumn = "Release App.ID"; break;
                default: FilterColumn = "None"; break;
            }

            if (txtFiliter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dt.DefaultView.RowFilter = "";
                lblrecord.Text = dataGridView1.RowCount.ToString();
                return;
            }

            if (FilterColumn == "D.ID" || FilterColumn == "Release App.ID")

                _dt.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFiliter.Text.Trim());
            else

                _dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFiliter.Text.Trim());

            lblrecord.Text = dataGridView1.RowCount.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiliter.Visible = (comboBox1.Text != "None");

            if (txtFiliter.Visible)
            {
                txtFiliter.Text = "";
                txtFiliter.Focus();
            }
        }


    }
}
