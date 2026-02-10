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
    public partial class ucDriverLicense : UserControl
    {
        int PersonID = 0;
        DataTable dtLocalLicense, dtInternationalLicense;
        public ucDriverLicense()
        {
            InitializeComponent();
        }

        public ucDriverLicense(int PrsonID)
        {
            InitializeComponent();

            this.PersonID = PrsonID;

        }


        public void LoadHistory(int PrsonID)
        {
            this.PersonID = PrsonID;
            RefershData();

        }


        private void RefershData()
        {
            dtLocalLicense = clsLocalAppcs.GetLocalLicenseHistory(PersonID);
            dtInternationalLicense = clsInternationalLicense.GetInternationalHistoryByPersonID(PersonID);

            if (dtLocalLicense == null || dtInternationalLicense == null)
            {
                return;
            }


            dgvLocalLicenseHistory.DataSource = dtLocalLicense;
            dgvInternationalLicense.DataSource = dtInternationalLicense;

            lblTotalLocalRecords.Text = dgvLocalLicenseHistory.RowCount.ToString();
            lblTotalInternationalRecords.Text = dgvInternationalLicense.RowCount.ToString();
        }


        private int _GetSelectedLocalLicenseID()
        {           
            if (dgvLocalLicenseHistory.CurrentRow == null) return -1;

            return (int)dgvLocalLicenseHistory.CurrentRow.Cells[0].Value;
        }

        private int _GetSelectedInternationalLicenseID()
        {
            if (dgvInternationalLicense.CurrentRow == null) return -1;
          
            return (int)dgvInternationalLicense.CurrentRow.Cells[0].Value;
        }
        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (dgvLocalLicenseHistory.Rows.Count > 0)
                {
                    int LicenseID = _GetSelectedLocalLicenseID();
                    if (LicenseID == -1)
                    {
                        return;
                    }
                    frmShowLicense frm = new frmShowLicense(clsLicense.Find(LicenseID));
                    frm.ShowDialog();
                }


            }
            else
            {
                if (dgvInternationalLicense.Rows.Count > 0)
                {
                    frmInternationalDriverLicenseInfo frm = new frmInternationalDriverLicenseInfo(_GetSelectedInternationalLicenseID());
                    frm.ShowDialog();
                }
            }


        }


    }
}
