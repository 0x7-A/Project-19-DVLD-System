using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsManageAppTypes
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees {  get; set; }


        public clsManageAppTypes(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees) {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }


        public static DataTable GetAllTheAppTypes()
        {
            return clsDataManageAppTypes.GetAllAppTypes();
        }

        public static bool Update(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            return clsDataManageAppTypes.UpdateAppType(ApplicationTypeID,ApplicationTypeTitle,ApplicationFees);
        }

        //

        public static  bool GetApplicationFeesAndDescription(int ApplicationTypeID, ref decimal Fees,ref string Description)
        {
            return clsDataManageAppTypes.GetAppInfo(ApplicationTypeID,ref Fees,ref Description);
        }

    }
}
