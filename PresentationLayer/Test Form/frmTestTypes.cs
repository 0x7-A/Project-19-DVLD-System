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
    public partial class frmTestTypes : Form
    {
        clsTestTypes _CurrnetType;

        Form frm;
        public frmTestTypes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

        private void _RefreshData()
        {

            dataGridView1.DataSource = clsTestTypes.GetAllTestTypes();
            lblTotalRecord.Text = (dataGridView1.RowCount - 1).ToString();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TargetedID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            _CurrnetType = clsTestTypes.FindTestType(TargetedID);
            if (_CurrnetType != null)
            {
                frm = new frmEditTestype(_CurrnetType);
                frm.ShowDialog();
                _RefreshData();
            }
            else
            {
                MessageBox.Show("Something Went Wrong, try later");
            }

        }
    }
}
