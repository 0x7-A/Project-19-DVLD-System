using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;


namespace Project_DataAccessLayer
{
    public class clsDataUsers
    {
        public static bool login(string username, string password,
            ref int personID, ref int UserID, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "select * from Users where Username=@username and Password=@password;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            bool isfound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    personID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                    isActive = (bool)reader["IsActive"];




                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }


        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT Users.UserID, Users.PersonID, FullName = People.FirstName + ' '  + People.SecondName + ' ' + People.ThirdName + ' ' +People.LastName, Users.UserName, Users.IsActive FROM   Users INNER JOIN   People ON Users.PersonID = People.PersonID";
            SqlCommand cmd = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool FindByUserID(int UserID, ref int personID, ref string username, ref string password, ref bool isActive)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "select * from Users where UserID=@UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);


            bool isfound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    personID = (int)reader["PersonID"];
                    isActive = (bool)reader["IsActive"];
                    password = (string)reader["Password"];
                    username = (string)reader["UserName"];




                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }


        public static bool Update(int UserID, int PersonID, string username, string NewPassword, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "update Users set   UserName=@UserName , Password=@Password , IsActive=@IsActive where UserID=@UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Password", NewPassword);
            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("IsActive", IsActive);

            try
            {
                connection.Open();
                return cmd.ExecuteNonQuery() > 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }


        }

        public static bool DeleteUserByID(int UserID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "delete Users where UserID=@UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                return cmd.ExecuteNonQuery() > 0;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public static bool DoesUserExistsWithPersonID(int PersonID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT TOP 1 1 FROM Users WHERE PersonID = @PersonID ;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return true;
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public static bool DoesUserNameExists(string UserName)
        {


            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT TOP 1 1 FROM Users WHERE UserName= @UserName ;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return true;
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return false;

        }

        public static  bool AddNewUser(ref int UserID,int PersonID, string username, string password, bool isActive)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "INSERT INTO Users (PersonID,UserName,Password,IsActive) values (@PersonID,@Username,@Password,@IsActive); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                    return true;
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
                return false;
            }
            finally
            {
                connection.Close() ;
            }

            return false;
        }











    }
}
