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
    public partial class frmManageAppTypes : Form
    {
       
        public frmManageAppTypes()
        {
            InitializeComponent();
        }

        private void frmManageAppTypes_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void _Refresh()
        {
            dataGridView1.DataSource = clsManageAppTypes.GetAllTheAppTypes();
            lblTotalRecord.Text = dataGridView1.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Form frm = new frmEditAppTypes((int)dataGridView1.CurrentRow.Cells[0].Value,
                (string)dataGridView1.CurrentRow.Cells[1].Value,(decimal) dataGridView1.CurrentRow.Cells[2].Value);
             frm.ShowDialog();
            _Refresh();

        }
    }
}
