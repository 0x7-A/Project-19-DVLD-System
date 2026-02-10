using Microsoft.Data.SqlClient;
using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsLicenseClasses
    {

        public string ClassName { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }


        public static clsLicenseClasses FindClassInfoByLicenseID(int LicenseID)
        {
            string className = "";
            byte validity = 0;
            decimal fees = 0;

            if (clsDataLicenseClasses.GetClassInfoByLicenseID(LicenseID, ref className, ref validity, ref fees))
            {
                return new clsLicenseClasses
                {
                    ClassName = className,
                    DefaultValidityLength = validity,
                    ClassFees = fees
                };
            }
            else
            {
                return null;
            }
        }


        public static DataTable GetLicenseIDAndClassName()
        {
            return clsDataLicenseClasses.GetClassesNameAndID();
        }

        public static int GetClassLicenseIDUseingClassName(string className)
        {
            int ClassID = -1;


            clsDataLicenseClasses.GetClassLicenseIDUsingClassName(className, ref ClassID);
            return ClassID;
        }
       

        public static string GetClassNameUsingClassLID(int ClassLicenseID)
        {
            string ClassName = "";

            clsDataLicenseClasses.GetClassNameUsingClassID(ClassLicenseID, ref ClassName);
            return ClassName;

        }

    }
}
