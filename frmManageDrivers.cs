
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
    public partial class FrmManageDrivers : frmManagement
    {
        DataTable dt;

        public FrmManageDrivers()
        {
            InitializeComponent();
        }

        private void FrmManageDrivers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            dt = clsDrivers.GetAllDrivers();
            dataGridView1.DataSource = dt;
            lblrecord.Text = dataGridView1.RowCount.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
