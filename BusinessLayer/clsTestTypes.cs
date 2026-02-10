using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsTestTypes
    {

        public int TestTypeID {  get; set; }

        public string TestTypeTitle {  get; set; }

        public string TestTypeDescription {  get; set; }

        public  decimal TestTypeFee {  get; set; }
            

        public clsTestTypes(int TestTypeID, string TestTypeTitle, string
            TestTypeDescription, decimal TestTypeFee)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFee = TestTypeFee;

        }

        public static DataTable GetAllTestTypes()
        {
            return clsDataTestTypes.GetAllTestType();
        }

        public static clsTestTypes FindTestType(int ID)
        {
            decimal Fees = 0;
            string Title = "", Description = "";

            if (clsDataTestTypes.FindTestTypeByID(ID,ref Title,ref Description,ref Fees))
            {
                return new clsTestTypes(ID,Title,Description,Fees);
            }
            else
            {
                return null; 
            }

        }

        public static bool UpdateTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFee)
        {
            return clsDataTestTypes.Update(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFee);               
        }

    }
}
