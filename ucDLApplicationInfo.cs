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
    public partial class ucDLApplicationInfo : UserControl
    {
        public ucDLApplicationInfo()
        {
            InitializeComponent();
        }

        public void Loadobject(clsLocalAppcs _App)
        {
            lblDLAppID.Text = _App.LocalDrivingLicenseApplicationID.ToString();
            lblClassName.Text = _App.LicenseClassName;
            lblPassedTest.Text = _App.PassedTestCount.ToString();
        
        }



    }
}
