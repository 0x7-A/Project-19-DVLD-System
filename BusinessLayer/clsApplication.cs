using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project19_businessLayer.clsLicense;

namespace Project19_businessLayer
{
    public class clsApplication
    {
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public enum enTestType { Vision = 1, Written = 2, Street = 3 };

    

        public enum enApplicationType
        {	NewLocalDrivingLicenseService = 1,RenewDrivingLicenseService = 2, ReplacementforaLostDrivingLicense = 3,	
	ReplacementforaDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5,NewInternationalLicense = 6,RetakeTest = 8}

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public byte ApplicationStatus { get; set; } 
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; } 
        public int CreatedByUserID { get; set; }

      
        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = 1; 
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
        }

      
        public clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
                              int ApplicationTypeID, byte ApplicationStatus, DateTime LastStatusDate,
                              decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
        }

        public static clsApplication Find(int ApplicationID)
        {
            
            int PersonID = -1, TypeID = -1, CreatedByUserID = -1;
            byte Status = 1;
            DateTime Date = DateTime.Now, LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;

           
            if ( clsDataApplication.FindApplicationInfoByID(ApplicationID,
                ref PersonID, ref Date, ref TypeID, ref Status,
                ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
              
                return new clsApplication(ApplicationID, PersonID, Date,
                    TypeID, Status, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
               
                return null;
            }
        }



    }


}
