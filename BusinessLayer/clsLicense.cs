using Project_DataAccessLayer;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsLicense
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public string IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsDetained { get; set; }
        public clsApplication ApplicationInfo { get; set; }

        public int IssuedUsingLocalLicenseID { get; set; }

        public enum enIssueReason : byte
        {
            FirstTime = 1,
            Renew = 2,
            ReplacementDamaged = 3,
            ReplacementLost = 4
        };

        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = true;
            this.IssueReason = "";
            this.CreatedByUserID = -1;
            this.IsDetained = false;
            this.ApplicationInfo = new clsApplication();


        }


        public clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
                          DateTime IssueDate, DateTime ExpirationDate, string Notes,
                          decimal PaidFees, bool IsActive, string IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.IsDetained = false;
            this.ApplicationInfo = clsApplication.Find(this.ApplicationID);
            this.IsDetained = clsDataLicense.IsLicenseDetained(this.LicenseID);
        }



        public static clsLicense FindLicenseByLDLAppID(int LDLAppID)
        {

            int ApplicationID = -1, LicenseID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "", IssueReason = "";
            decimal PaidFees = 0;
            bool IsActive = true;


            if (clsDataLicense.GetLicenseByLDLAppID(LDLAppID,
                ref ApplicationID, ref LicenseID, ref DriverID, ref LicenseClass,
                ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees,
                ref IsActive, ref IssueReason, ref CreatedByUserID))
            {

                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass,
                                       IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }

        }

        public static bool CanIssueInternationalLicense(ref string ErrorMessage, clsLicense License)
        {
            if (License.LicenseClass != 3)
            {
                ErrorMessage = "Selected License must be Class 3 (Ordinary) to issue an International License.";
                return false;
            }


            if (!License.IsActive)
            {
                ErrorMessage = "Selected License is NOT Active. You cannot issue an International License for it.";
                return false;
            }


            if (License.ExpirationDate < DateTime.Now)
            {
                ErrorMessage = "Selected License is Expired. Please renew it first.";
                return false;
            }


            if (License.IsDetained)
            {
                ErrorMessage = "Selected License is Detained. You must release it first.";
                return false;
            }

            int ILAppID = -1;


            if (clsDataInternationalLicense.CheckIfTheLicenseIDUsed(License.LicenseID, ref ILAppID))
            {
                ErrorMessage = "Person already has an active International License with ID: " + ILAppID.ToString();
                return false;
            }


            ErrorMessage = "";
            return true;
        }


        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReasonByte = 0;


            if (clsDataLicense.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID,
                ref LicenseClass, ref IssueDate, ref ExpirationDate, ref Notes,
                ref PaidFees, ref IsActive, ref IssueReasonByte, ref CreatedByUserID))
            {

                string IssueReasonString = _MapIssueReason(IssueReasonByte);


                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClass,
                                      IssueDate, ExpirationDate, Notes, PaidFees,
                                      IsActive, IssueReasonString, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }


        private static string _MapIssueReason(byte ReasonID)
        {
            switch (ReasonID)
            {
                case 1: return "First Time";
                case 2: return "Renew";
                case 3: return "Replacement for Damaged";
                case 4: return "Replacement for Lost";
                default: return "First Time";
            }
        }


        public static int RenewLicense(int OldLicenseID, int NewApplicationID, int DriverID,
                                int LicenseClass, DateTime ExpirationDate,
                                decimal PaidFees, string Notes, int CreatedByUserID)
        {

            if (!clsDataLicense.DiactivateLicense(OldLicenseID, false))
            {
                return -1;
            }

            return clsDataLicense.AddNewLicense(
                NewApplicationID,
                DriverID,
                LicenseClass,
                DateTime.Now,
                ExpirationDate,
                Notes,
                PaidFees,
                true,
                (byte)enIssueReason.Renew,
                CreatedByUserID
            );
        }

        public static int AddNewLicense(int ApplicationID,int DriverID, int LicenseClass,string Notes, decimal PaiedFees,byte IssueReason,int CreatedBy)
        {

            clsLicenseClasses CL = clsLicenseClasses.FindClassInfoByLicenseID(LicenseClass);

            DateTime ExpirationDate = DateTime.Now.AddYears(CL.DefaultValidityLength);
            return clsDataLicense.AddNewLicense(ApplicationID, DriverID, LicenseClass, DateTime.Now, ExpirationDate, Notes, PaiedFees, true, IssueReason, CreatedBy);
        }

        public static bool CanRenewLicense(ref string ErrorMessage, DateTime ExpirationDate, bool IsActive, int LicenseID)
        {
            if (!IsActive)
            {
                ErrorMessage = "This license is NOT active and cannot be renewed.";
                return false;
            }


            if (ExpirationDate > DateTime.Now)
            {
                ErrorMessage = "This license is not expired yet. You can't renew it now.";
                return false;
            }




            if (clsDataLicense.IsLicenseDetained(LicenseID))
            {
                ErrorMessage = "This license is Detained. You can't renew it now till you released it";
                return false;
            }

            return true;

        }


        public static bool CanGetreplacementLicense(ref string ErrorMessage, DateTime ExpirationDate, bool IsActive, int LicenseID)
        {
            if (!IsActive)
            {
                ErrorMessage = "This license is NOT active and cannot be replacement.";
                return false;
            }

            if (clsDataLicense.IsLicenseDetained(LicenseID))
            {
                ErrorMessage = "This license is Detained. You can't replace it now till you released it";
                return false;
            }

            if (ExpirationDate < DateTime.Now)
            {
                ErrorMessage = "This license is not expired, you should renew it";
                return false;
            }

            return true;

        }


        public static int GetReplacementLicense(int OldLicenseID, int NewApplicationID, int DriverID,
                                int LicenseClass, DateTime ExpirationDate,
                                decimal PaidFees, string Notes, int CreatedByUserID, clsLicense.enIssueReason reason)
        {

            if (!clsDataLicense.DiactivateLicense(OldLicenseID, false))
            {
                return -1;
            }

            return clsDataLicense.AddNewLicense(
                NewApplicationID,
                DriverID,
                LicenseClass,
                DateTime.Now,
                ExpirationDate,
                Notes,
                PaidFees,
                true,
                (byte)reason,
                CreatedByUserID
            );


        }



    





}


}
