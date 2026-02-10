using Project_DataAccessLayer;
using System.Data;

namespace Project19_businessLayer
{
    public class clsUsers
    {
        enum enMode {AddNew =0, Update = 1 }
        enMode Mode;

        public  int UserID { get; set; }
        public int PersonID {  get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool isActive {  get; set; }


        public clsUsers()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.userName = "";
            this.password = "";
           
            this.Mode = enMode.AddNew;
           
        }

        public clsUsers(int UserID, int PersonID, string userName, string password, bool isActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.userName = userName;
            this.password = password;
            this.isActive = isActive;
               
        }


        public static clsUsers Login(string username,string password)
        {
           
            int PersonID =-1, UserID = -1;
            bool isActive = false;

            if(clsDataUsers.login(username, password,ref PersonID,ref UserID, ref isActive))
            {
                return new clsUsers(UserID, PersonID, username, password,isActive);
            }
            else
            {
                return null;
            }



        }

        public static clsUsers FindByID(int UserID)
        {
            int PersonID = -1;
            bool isActive = false;
            string username = "", password = "";

            if(clsDataUsers.FindByUserID(UserID,ref PersonID, ref username, ref password,ref isActive))
            {
                return new clsUsers(UserID, PersonID, username, password, isActive);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllUsers()
        {
            return  clsDataUsers.GetAllUsers();
        }

       public static bool Update(int UserID, int PersonID, string username, string Password,bool IsActive)
       {
            return clsDataUsers.Update(UserID, PersonID, username, Password,IsActive);  
       }

        public static bool DeleteUser(int UserID)
        {
            return clsDataUsers.DeleteUserByID(UserID);
        }

        public static bool DoesUserExistsWithPersonID(int PersonID)
        {
            return clsDataUsers.DoesUserExistsWithPersonID(PersonID);
        }

        public static bool DoesUserNameExists(string UserName)
        {
            return clsDataUsers.DoesUserNameExists(UserName);
        }

        public static bool AddNewUser(ref  int UserID, int PersonID ,string UserName,string password, bool isActive)
        {
            return clsDataUsers.AddNewUser(ref  UserID,PersonID,UserName,password,isActive);
        }

       
       

    }
}
