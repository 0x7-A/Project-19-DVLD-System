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
    public partial class ucDetainInfo : UserControl
    {
        public ucDetainInfo()
        {
            InitializeComponent();
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }


            bool isDigit = char.IsDigit(e.KeyChar);


            bool isDecimalPoint = (e.KeyChar == '.');

            if (!isDigit && !isDecimalPoint)
            {
                e.Handled = true;
            }

            if (isDecimalPoint && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
