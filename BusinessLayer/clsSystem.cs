using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsSystem
    {
        public static clsUsers CurrentUser;


        public static decimal NewApplicationsFees = 5;
        public static bool WriteLoginInfo(string username,string password)
        {
           return clsDataLogin.WriteLoginData(username, password);
        }

        public static bool ReadLoginFile(ref string username, ref string password)
        {
            return clsDataLogin.ReadLoginFile(ref username, ref password);
        }

        public static void ClearLoginFile()
        {
            clsDataLogin.ClearFile();
        }


    }
}
