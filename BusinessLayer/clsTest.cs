using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsTest
    {

        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedBy)
        {
            int NewTestID = -1;
            clsDataTests.AddNewTest(ref NewTestID,TestAppointmentID, TestResult, Notes, CreatedBy);
            return NewTestID;
        }

        public static int GetTotalTrials(int LDLID, clsApplication.enTestType Type )
        {
            return clsDataTestAppointments.GetTotalTrialsPerTest(LDLID ,(int)Type);
        }


        public static bool IsPassedAlready(int LDLApp, clsApplication.enTestType Type)
        {
            return clsDataTests.IsPassedTestAlready(LDLApp ,(int)Type);
        }

        public static bool NeedsRetakeTest(int LDLApp, clsApplication.enTestType Type )
        {
            return clsDataTests.NeedsRetakeTest(LDLApp, (int)Type);
        }



    }



}
