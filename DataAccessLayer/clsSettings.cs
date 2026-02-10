using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
    static class clsSettings
    {

        public static string FileName = "Login.txt";
        public static char Seprator = '#';

        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLD_ConnectionString"].ConnectionString;
    }

}