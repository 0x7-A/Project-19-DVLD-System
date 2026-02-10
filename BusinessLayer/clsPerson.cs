using Project_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project19_businessLayer
{
    public class clsPerson
    {
      

        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName {  get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gendor { get; set; }
      

        public string CountryName { get; set; } 
        public string ImagePath { get; set; }


        public clsPerson()
        {



        }

        public clsPerson(int PersonID, string NationalNumber, string FirstName,
    string SecondName, string ThirdName, string LastName, DateTime DateOfBirth,
    int Gendor, string Address, string Phone, string Email,
     string CountryName, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor; 
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.CountryName = CountryName;
            this.ImagePath = ImagePath;

       
        }

        public static DataTable GetAllCountries()
        {
            return clsDataCountry.GetAllCountries();
        }
        public static DataTable GetAllPeople()
        {
            return clsDataPerson.GetAllPeople();
        }
        public static bool DeleteByID(int ID)
        {
            return clsDataPerson.DeletePersonByID(ID);  
        }

        public static bool DoesPersonExists(string NationalNumber)
        {
            return clsDataPerson.DoesPersonExistsByNationalNo(NationalNumber);
        }

        public static bool AddNewPerson(ref int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName,
          string LastName, DateTime DateOfBirth, int Gender, string Address, string phone, string Email, int CountryID, string ImagePath)
        {
            return clsDataPerson.AddNewPerson(ref PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, phone, Email, CountryID, ImagePath);
        }

        public static int GetCountryID(string CountryName)
        {
            return clsDataCountry.GetCountryID(CountryName);

        }

        public  static clsPerson FindPersonByID(int PersonID)
        {
           
            int Gender = 0;
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "", CountryName ="";
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);

            if(clsDataPerson.FindByID(PersonID,
    ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
     DateOfBirth, ref Gender, ref Address, ref Phone, ref Email,ref ImagePath, ref CountryName ))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName,
        LastName, DateOfBirth, Gender, Address, Phone, Email, CountryName, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static bool Update(int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName,
          string LastName, DateTime DateOfBirth, int Gender, string Address, string phone, string Email, int CountryID, string ImagePath)
        {
            return clsDataPerson.Update(PersonID, NationalNumber, FirstName, SecondName,
        ThirdName, LastName, DateOfBirth, Gender, Address, phone, Email,
        CountryID, ImagePath);
        }


        public static clsPerson FindPersonByNationalNo(string NationalNo)
        {

            int  PersonID = -1,Gender = 0;
           string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "", CountryName = "";
            DateTime DateOfBirth = DateTime.Now.AddYears(-18);

            if (clsDataPerson.FindByNationalNumber(ref PersonID,NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
     DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref ImagePath, ref CountryName))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName,
        LastName, DateOfBirth, Gender, Address, Phone, Email, CountryName, ImagePath);
            }
            else
            {
                return null;
            }

        }

        public static int GetPersonIDByDriverID(int driverID)
        {
           return clsDataPerson.GetPersonIDByDriverID(driverID);
           
        }



    }
}
