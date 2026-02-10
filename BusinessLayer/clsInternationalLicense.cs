using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsInternationalLicense
    {

        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public int ApplicantPersonID { get; set; }

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1; 
            this.IsActive = true;
        }

        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID,
            int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID, int ApplicantPersonID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.ApplicantPersonID = ApplicantPersonID;
        }


        public static DataTable GetInternationalHistoryByPersonID(int PersonID)
        {
            return clsDataInternationalLicense.GetInternationalHistoryByPersonID(PersonID);
        }

        public static DataTable GetAllinternationalApplication()
        {
            return clsDataInternationalLicense.GetMangeInternationalAppDataTable();
        }

        public static  bool AddNewInternationalApplication(ref int ApplicationID,ref int InternationalID ,int PersonID, decimal PaidFees,int CreatedByUser,int DriverID,int IssuedUsingLocalLicenseID,DateTime ExpirationDate)
        {
            return (clsDataApplication.AddNewApplication(ref ApplicationID, PersonID, DateTime.Now, (int)clsApplication.enApplicationType.NewInternationalLicense,
                  (int)clsApplication.enApplicationStatus.Completed, DateTime.Now, PaidFees, CreatedByUser) && clsDataInternationalLicense.AddNewInternationalLicense(ref InternationalID, ApplicationID
                 , DriverID, IssuedUsingLocalLicenseID,DateTime.Now,  ExpirationDate, true, CreatedByUser ));
        }

       public static clsInternationalLicense GetInternationalLicenseInfo(int InternationalLicenseID)
        {
            int AppID = -1, DriverID = -1, LocalLID = -1, UserID = -1, PersonID = -1;
            DateTime IDate = DateTime.Now, EDate = DateTime.Now;
            bool Active = false;

           
            if (clsDataInternationalLicense.GetInternationalLicenseByID(InternationalLicenseID,
                ref AppID, ref DriverID, ref LocalLID, ref IDate, ref EDate, ref Active, ref UserID, ref PersonID))
            {
                return new clsInternationalLicense(InternationalLicenseID, AppID, DriverID,
                    LocalLID, IDate, EDate, Active, UserID, PersonID);
            }
            else
            {
                return null;
            }
        }

    }
}
