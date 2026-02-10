using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Project19_businessLayer
{
    public class clsLocalAppcs
    {

        public int LocalDrivingLicenseApplicationID { get; set; }
        public clsApplication APPLICATION { get; set; }
        public string LicenseClassName { get; set; }

 

        public byte PassedTestCount { get; set; }

        enum enStatus { New = 1, Cancelled = 2, Completed = 3 }

        public static DataTable GetllApplications()
        {

            return clsDataLocalDrivingLicenseApp.GetAllLocalAppTyeps();
        }

        public static bool CheckFromPreviousApp(ref int LDLAppID,int PersonID,int LicenseClass)
        {
            return clsDataLDLApplication.CheckFromPreivousApp(ref LDLAppID, PersonID, LicenseClass);    
        }
        public static int AddNewApplication(int PersonID, int UserID, clsApplication.enApplicationType Type,
            clsApplication.enApplicationStatus status)
        {
            int ApplicationID = -1;
            if (!clsDataApplication.AddNewApplication(ref ApplicationID, PersonID, DateTime.Now, (int)Type , (int) status, DateTime.Now, clsSystem.NewApplicationsFees, UserID))
            {
                return -1;
            }
            return ApplicationID;
        }


        public static int AddNewLDLApp(int PersonID,int UserID,int LicenseClassID)
        {
            int AppID = -1, LDLAppID = -1;

            if (!clsDataApplication.AddNewApplication(ref AppID, PersonID, DateTime.Now,1,1,DateTime.Now,clsSystem.NewApplicationsFees,UserID))
            {
                return -1;
            }

            if(clsDataLDLApplication.AddNewLDLApp(ref LDLAppID,AppID, LicenseClassID))
            {
                return LDLAppID;
            }
           
            return -1;
        }

        public static bool DeleteLDLApp(int LDLAppID, int PersonID, int LicenseClass)
        {
            int ApplicationID = -1;
                if (clsDataApplication.FindAppIDbyLDLApp(ref ApplicationID, PersonID, LicenseClass))
                {
                   

                    if (clsDataLDLApplication.DeleteLDLApp(LDLAppID))
                    {
                  
                        return clsDataApplication.DeleteByApplicationID(ApplicationID);
                    }
                }


            

            return false;

        }

       
        public static bool Update(int ApplicationID,int ApplicationTypeID,int ApplicationStatus)
        {
            return clsDataLDLApplication.UpdateApplicationToCancell(ApplicationID, ApplicationTypeID, ApplicationStatus);
        }

        public static bool UpdateToCancelled(int PersonID, int LicenseClass)
        {
            int ApplicationID = -1;

           if(clsDataApplication.FindAppIDbyLDLApp(ref ApplicationID, PersonID, LicenseClass))
           {
                return Update(ApplicationID, 1, (int)enStatus.Cancelled);
            }

            return false;
        }

        public static clsLocalAppcs FindByLocalDrivingAppID(int LocalDrivingLicenseApplicationID)
        {
          
            int ApplicationID = -1, ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            decimal PaidFees = 0; byte ApplicationStatus = 1;
            string LicenseClassName = "";
            byte PassedTestCount = 0;

            if (clsDataLDLApplication.GetLocalDrivingLicenseApplicationInfoByID(
                LocalDrivingLicenseApplicationID, ref ApplicationID, ref ApplicantPersonID,
                ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus,
                ref LastStatusDate, ref PaidFees, ref CreatedByUserID, ref LicenseClassName, ref PassedTestCount))
            {
               
                clsApplication baseApplication = new clsApplication(ApplicationID, ApplicantPersonID,
                    ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate,
                    PaidFees, CreatedByUserID);

             
                return new clsLocalAppcs()
                {
                    LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID,
                    APPLICATION = baseApplication, 
                    LicenseClassName = LicenseClassName, PassedTestCount=PassedTestCount
                };
            }
            return null;
        }

        public static DataTable GetLocalLicenseHistory(int PersonID)
        {
            return clsDataLocalDrivingLicenseApp.GetLocalLicenseHistoryByID(PersonID);
        }



    }
}
