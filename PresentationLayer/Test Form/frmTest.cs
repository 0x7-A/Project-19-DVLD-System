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
    public partial class frmTest : Form
    {

        private clsApplication.enTestType _Type;
        private DataTable _dt;
        private int _LDL;
        private clsLocalAppcs _LocalAppcs;


        public frmTest(int LDL, clsApplication.enTestType testType)
        {
            InitializeComponent();
            _LDL = LDL;
            _Type = testType;



            _LocalAppcs = clsLocalAppcs.FindByLocalDrivingAppID(LDL);
            if (_LocalAppcs == null)
            {
                MessageBox.Show("Something went wrong");
                return;
            }
            Check();
        }

        private void LoadDataTable()
        {
            _dt = clsAppointments.GetAllTestAppointments(_LDL, _Type);
            if (_dt == null)
            {
                return;
            }

            dataGridView1.DataSource = _dt;
            lblTotalRecords.Text = _dt.Rows.Count.ToString();
        }

        private void Check()
        {
            FillTitleAndPic();
            LoadDataTable();
            ucApplicationBasicInfo1.LoadObject(_LocalAppcs.APPLICATION);
            ucdlApplicationInfo1.Loadobject(_LocalAppcs);

        }

        private void FillTitleAndPic()
        {
            switch (_Type)
            {

                case clsApplication.enTestType.Vision:
                    pbTitle.Image = Resources.Vision_512;
                    break;

                case clsApplication.enTestType.Written:
                    pbTitle.Image = Resources.Written_Test_512;
                    break;
                case clsApplication.enTestType.Street:
                    pbTitle.Image = Resources.Street_Test_32;
                    break;
            }

            lblTitle.Text = _Type.ToString() + " Test";
            this.Text = _Type.ToString() + " Test";

        }

        private void ucApplicationBasicInfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            if (clsAppointments.HasAnActiveAppointement(_LDL, _Type))
            {
                MessageBox.Show("Already have an Active appointement");
                return;
            }

            if (clsTest.IsPassedAlready(_LDL, _Type))
            {
                MessageBox.Show("Already passed the exam");
                return;
            }



            frmSceduleTest frm = new frmSceduleTest(_LDL, _Type);
            frm.ShowDialog();
            LoadDataTable();


        }




        private bool IsSelectedDGVnull()
        {
            return dataGridView1.CurrentRow == null;
        }
        private bool IsSelectedRowLocked()
        {
            return (bool)dataGridView1.CurrentRow.Cells["Is Locked"].Value;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            editToolStripMenuItem.Enabled = true;
            takeTestToolStripMenuItem.Enabled = true;

            if (IsSelectedDGVnull())
            {
                editToolStripMenuItem.Enabled = false;
                takeTestToolStripMenuItem.Enabled = false;
                return;
            }

            if (IsSelectedRowLocked())
            {
                editToolStripMenuItem.Enabled = false;
                takeTestToolStripMenuItem.Enabled = false;
                return;
            }
        }


        private int GetSelectedTestAppointment()
        {
            return (int)dataGridView1.CurrentRow.Cells["TestAppointment ID"].Value;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSceduleTest frm = new frmSceduleTest(_LDL, _Type, GetSelectedTestAppointment());
            frm.ShowDialog();
            LoadDataTable();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest(GetSelectedTestAppointment());
            frm.ShowDialog();
            LoadDataTable();
        }
    }
}
