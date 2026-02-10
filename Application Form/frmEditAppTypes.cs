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
    public partial class frmEditAppTypes : Form
    {
        

        public frmEditAppTypes(int ID,string title,decimal fee)
        {
            InitializeComponent();
            _FillData(ID,title,fee);
        }

        private void frmEditManageAppTypes_Load(object sender, EventArgs e)
        {

        }

        private void _FillData(int ID, string title, decimal fee)
        {
            lblID.Text = ID.ToString();
            txtTitle.Text = title;
            txtFees.Text = fee.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckIsNull()
        {
            return string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtFees.Text); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CheckIsNull())
            {
                MessageBox.Show("Error, Make sure you fill all the boxes");
                this.Close();
                return;
            }
            

          
           if(clsManageAppTypes.Update(int.Parse(lblID.Text), txtTitle.Text,decimal.Parse(txtFees.Text)))
               {
                MessageBox.Show("Data updated secessfully");
                
                }
             else
             {
                    MessageBox.Show("Somthing went wrong");
              }
            
            this.Close();

        }
    }
}
