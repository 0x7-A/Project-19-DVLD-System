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
    public partial class frmSceduleTest : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsApplication.enTestType _TestType;
        private int _AppointmentID = -1;

      
        public frmSceduleTest(int LocalDrivingLicenseApplicationID, clsApplication.enTestType TestType, int AppointmentID = -1)
        {
            InitializeComponent();

            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestType = TestType;
            _AppointmentID = AppointmentID;
        }

        private void frmSceduleTest_Load(object sender, EventArgs e)
        {
            
            ucScheduledTest1.SetInfo(_LocalDrivingLicenseApplicationID, _TestType);

           
            if (_AppointmentID != -1)
            {
                ucScheduledTest1.LoadData(_AppointmentID);
            }
        }



    }
}
