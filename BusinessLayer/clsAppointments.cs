using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsAppointments
    {
        public int TestAppointmentID { get; set; }
        public clsApplication.enTestType TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

       
        private clsAppointments(int ID, clsApplication.enTestType TypeID, int LDLAppID,
            DateTime AppDate, decimal Fees, int UserID, bool Locked, int RetakeID)
        {
            this.TestAppointmentID = ID;
            this.TestTypeID = TypeID;
            this.LocalDrivingLicenseApplicationID = LDLAppID;
            this.AppointmentDate = AppDate;
            this.PaidFees = Fees;
            this.CreatedByUserID = UserID;
            this.IsLocked = Locked;
            this.RetakeTestApplicationID = RetakeID;
        }

   
        public static clsAppointments Find(int TestAppointmentID)
        {
            int TestTypeID = -1, LDLAppID = -1, UserID = -1, RetakeID = -1;
            DateTime AppDate = DateTime.Now;
            decimal Fees = 0;
            bool Locked = false;

            if (clsDataTestAppointments.GetTestAppointmentInfoByID(TestAppointmentID,
                ref TestTypeID, ref LDLAppID, ref AppDate, ref Fees, ref UserID, ref Locked, ref RetakeID))
            {
                return new clsAppointments(TestAppointmentID, (clsApplication.enTestType)TestTypeID,
                    LDLAppID, AppDate, Fees, UserID, Locked, RetakeID);
            }
            return null;
        }

  
        public static bool UpdateDate(int TestAppointmentID,DateTime AppointmentDate)
        {
            return clsDataTestAppointments.UpdateAppointmentDate(TestAppointmentID, AppointmentDate);
        }

        public static DataTable GetAllTestAppointments(int LDLAppID,clsApplication.enTestType TestType)
        {
            return clsDataTestAppointments.GetAllTestAppoitementWLDLAppIDAndTestType(LDLAppID, (int)TestType);
        }

        public static int AddTestAppointment(clsApplication.enTestType Type, int LDLAppID, DateTime AppiontmentDate,
           decimal PaidFees, int RetakeTestID)
        {
            return clsDataTestAppointments.AddNewTestAppointment ((int) Type, LDLAppID,AppiontmentDate, PaidFees, clsSystem.CurrentUser.UserID,false, RetakeTestID);
            
        }


        public static  bool HasAnActiveAppointement(int LDL, clsApplication.enTestType Type)
        {
            return clsDataTestAppointments.HasAnActiveAppointments(LDL, (int) Type);
        }


       public static bool UpdateIsLockedToFalse(int TestAppointmentID)
        {
            return clsDataTestAppointments.UpdateIsLockedToFalse(TestAppointmentID);
        }



    }

}