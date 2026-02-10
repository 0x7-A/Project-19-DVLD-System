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
    public partial class ucRetakeTest : UserControl
    {
        public ucRetakeTest()
        {
            InitializeComponent();
        }

        public void Load(decimal RetakeTestFees, decimal TestFees)
        {
            lblRetakeTestFee.Text = RetakeTestFees.ToString();
            lblTotalFees.Text = (TestFees + RetakeTestFees).ToString();

        }

        public void SetRetakeApplicationID(int RetakeTestID)
        {
            lblRetakeTestAppID.Text = RetakeTestID.ToString();    
        }


      
    }
}
