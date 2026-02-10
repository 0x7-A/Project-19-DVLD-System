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
    public partial class frmManageInternationalLicense : Form
    {

        DataTable dt;
        private clsApplication _App;
        public frmManageInternationalLicense()
        {
            InitializeComponent();
            RefershData();
        }



        private int GetSelectedDriverID()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                return (int)dataGridView1.CurrentRow.Cells["Driver ID"].Value;
            }
            return -1;
        }



        private int GetSelectedInternationalNumber()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                return (int)dataGridView1.CurrentRow.Cells["Int. License ID"].Value;
            }
            return -1;
        }


        private int GetPersonIDByDriverID(int DriverID)
        {
            return clsPerson.GetPersonIDByDriverID(DriverID);
        }



        private void LoadComboBoxFilter()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("None");



            comboBox1.SelectedIndex = 0;
        }

        private void RefershData()
        {
            LoadComboBoxFilter();

            dt = clsInternationalLicense.GetAllinternationalApplication();

            if (dt == null)
            {
                return;
            }

            dataGridView1.DataSource = dt;
            lblrecord.Text = dataGridView1.RowCount.ToString();
        }



        private void showPersonDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails frm = new frmPersonDetails(GetPersonIDByDriverID(GetSelectedDriverID()));
            frm.ShowDialog();
        }

        private void showLicenseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalDriverLicenseInfo frm = new frmInternationalDriverLicenseInfo(GetSelectedInternationalNumber());
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmLicenseHistory frm = new frmLicenseHistory(GetPersonIDByDriverID(GetSelectedDriverID()));
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       




    }
}
