using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsDrivers
    {

        public static DataTable GetAllDrivers()
        {
            return clsDataDrivers.GetAllDrivers();
        }

        public static int AddNewDriverAndCheck(int PersonID, int CreatedBy)
        {
            if (!clsDataDrivers.CheckIfHasAlreadyDriverID(PersonID))
            {
               return clsDataDrivers.AddNewDriver(PersonID, CreatedBy);
            }
            else
            {
               return clsDataDrivers.GetDriverIDByPersonID(PersonID);
            }
           
        }



    }
}
