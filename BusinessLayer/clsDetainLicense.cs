using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project19_businessLayer
{
    public class clsDetainLicense
    {
       public enum enMode { Detain = 0, Release = 1 }
     

        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID
        {
            get; set;
        }


        public clsDetainLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MaxValue; 
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

          
        }

        private clsDetainLicense(int DetainID, int LicenseID, DateTime DetainDate,
    decimal FineFees, int CreatedByUserID, bool IsReleased,
    DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;

      
        }


        public static DataTable GetAllDetainedLicenses()
        {
            return clsDataDetainLicense.GetAllDetainedLicenses();
        }

        public static clsDetainLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1;
            DateTime DetainDate = DateTime.Now;
            decimal FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;


            if (clsDataDetainLicense.GetDetainedLicenseInfoByLicenseID(LicenseID,
                ref DetainID, ref DetainDate, ref FineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainLicense(DetainID, LicenseID, DetainDate, FineFees,
                    CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
            {
                return null; 
            }
        }


        public static bool Save(enMode Mode, clsLicense license, ref int ApplicationID,ref int DetainID, decimal Fees)
        {
            if (Mode == enMode.Release)
            {
                
                ApplicationID = clsLocalAppcs.AddNewApplication(license.ApplicationInfo.ApplicantPersonID, license.LicenseClass,
                     clsApplication.enApplicationType.ReleaseDetainedDrivingLicsense, clsApplication.enApplicationStatus.Completed);

                // upda
                if(ApplicationID != -1 && clsDataDetainLicense.ReleaseDetainedLicense(DetainID,clsSystem.CurrentUser.UserID, ApplicationID))
                {
                    return true;
                }
            }
            else
            {
                if(clsDataDetainLicense.AddNew(ref DetainID,license.LicenseID,DateTime.Now, Fees,clsSystem.CurrentUser.UserID))
                {
                    return true;
                }
            }
            return false;

        }
        






    }

}
