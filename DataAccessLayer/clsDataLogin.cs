using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DataAccessLayer
{
    public class clsDataLogin
    {
       
       

        public static bool ReadLoginFile(ref string username, ref string password)
        {

            try
            {


                if (!File.Exists(clsSettings.FileName))
                    return false;

                string Lines = File.ReadAllText(clsSettings.FileName);
                string[] lines = Lines.Split(clsSettings.Seprator);

                if (lines.Length == 2)
                {
                    username = lines[0];
                    password = lines[1];
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
       
         }


        public static bool WriteLoginData(string username, string password)
        {
            try
            {

               
                File.WriteAllText(clsSettings.FileName,username.Trim() + clsSettings.Seprator+ password.Trim());
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }




        }


        public static void ClearFile()
        {

            try
            {
                File.WriteAllText(clsSettings.FileName, "");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
          
        }





    }
}
