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
    public partial class ucApplicationBasicInfo : UserControl
    {

       
        private clsApplication _AppInfo;
        private clsUsers CreatedByUser;
        private clsPerson _Person;

        public ucApplicationBasicInfo()
        {
            InitializeComponent();
        }


        public void LoadObject(clsApplication _App)
        {
            _AppInfo = _App;
            _Person = clsPerson.FindPersonByID(_AppInfo.ApplicantPersonID);
            CreatedByUser = clsUsers.FindByID(_AppInfo.CreatedByUserID);

            if (CreatedByUser == null ||_AppInfo == null || _Person == null )
            {
                return;
            }

            LoadApplicationInfo();

        }

        private void LoadApplicationInfo()
        {
            lblID.Text = _AppInfo.ApplicantPersonID.ToString();
            lblStatus.Text = GetStatus();
            lblFees.Text = _AppInfo.PaidFees.ToString();
            lblType.Text = GetApplicationTypeTitle(_AppInfo.ApplicationTypeID); 
            lblApplicantName.Text = _Person.FirstName + " " + _Person.SecondName  + " " +  _Person.ThirdName + " " + _Person.LastName;

            lblCreatedDate.Text = _AppInfo.ApplicationDate.ToShortTimeString();
            lblStatusDate.Text = _AppInfo.LastStatusDate.ToShortTimeString();
            lblCreatedBy.Text = clsUsers.FindByID(_AppInfo.CreatedByUserID).userName; 
        }

        private string GetStatus()
        {
            switch(_AppInfo.ApplicationStatus)
            {
                case 1:
                    return "New";
                case 2:
                    return "Cancelled";
                case 3:
                    return "Completed";
            }
            return "";
        }

        public static string GetApplicationTypeTitle(int ApplicationTypeID)
        {
           
            switch (ApplicationTypeID)
            {
                case 1:
                    return "New Local Driving License";
                case 2:
                    return "Renew Driving License";
                case 3:
                    return "Replacement for a Lost Driving License";
                case 4:
                    return "Replacement for a Damaged Driving License";
                case 5:
                    return "Release Detained Driving License";
                case 6:
                    return "New International License";
                case 8:
                    return "Retake Test";
                default:
                    return "Unknown Type";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (_AppInfo != null)
            {
                frmPersonDetails frm = new frmPersonDetails(_AppInfo.ApplicantPersonID);
                frm.ShowDialog();

            }
        }



    }
}
