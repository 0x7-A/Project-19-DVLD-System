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
    public partial class frmEditTestype : Form
    {
        public frmEditTestype(clsTestTypes Type)
        {
            InitializeComponent();
            FillData(Type);
        }

        private void frmEditTestype_Load(object sender, EventArgs e)
        {

        }

        private void FillData(clsTestTypes Type)
        {
            lblID.Text = Type.TestTypeID.ToString();
            txtTitle.Text = Type.TestTypeTitle;
            txtDescription.Text = Type.TestTypeDescription;
            txtFee.Text = Type.TestTypeFee.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _CheckIsNull()
        {
            return string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtFee.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_CheckIsNull())
            {
                MessageBox.Show("Error, Make sure filling all the information");
                return;
            }

            if (clsTestTypes.UpdateTestTypes(int.Parse(lblID.Text), txtTitle.Text, txtDescription.Text, decimal.Parse(txtFee.Text)))
            {
                MessageBox.Show("successfully updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error happend druing updating");
                
            }
        }
    }
}
