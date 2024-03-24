using clsLibraryAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static clsBookLibraryAccessLayer.clsUsersData;

namespace clsBookLibraryAccessLayer
{
    public class clsUsersData
    {
        public struct stUserInfo
        {
            public int ID;
            public int PersonID;
            public string UserName;
            public string Password;
            public bool IsAdmin;
        }
        public static int AddNewUser(stUserInfo userInfo)
        {

            int ID;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Insert into Users(PersonID, UserName, Password, IsAdmin)
                 values (@PersonID, @UserName, @Password, @IsAdmin);
                select scope_Identity();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", userInfo.PersonID);
            command.Parameters.AddWithValue("UserName", userInfo.UserName);
            command.Parameters.AddWithValue("Password", userInfo.Password);
            command.Parameters.AddWithValue("IsAdmin", userInfo.IsAdmin);

            connection.Open();
            object obj = command.ExecuteScalar();
            ID = Convert.ToInt32(obj);
            connection.Close();
            return ID;
        }

        public static bool UpdateUser(int UserID, stUserInfo userInfo)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Update Users set PersonID = @PersonID, UserName = @UserName, Password = @Password, IsAdmin = @IsAdmin where ID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("PersonID", userInfo.PersonID);
            command.Parameters.AddWithValue("UserName", userInfo.UserName);
            command.Parameters.AddWithValue("Password", userInfo.Password);
            command.Parameters.AddWithValue("IsAdmin", userInfo.IsAdmin);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public static bool DeleteUser(int UserID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Delete from Users where UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from Users;";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
                dt.Load(reader);
            reader.Close();
            connection.Close();
            return dt;
        }

        public static bool IsExist(int UserID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select found = 1 from Users where UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }
        public static bool IsExist(string UserName)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select found = 1 from Users where UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }

        public static bool Find(int UserID, ref stUserInfo userInfo)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from Users where ID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID", UserID);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                userInfo.PersonID = (int)Reader["PersonID"];
                userInfo.UserName = (string)Reader["UserName"];
                userInfo.Password = (string)Reader["Password"];
                userInfo.IsAdmin = (bool)Reader["IsAdmin"];

                IsFound = true;
            }
            connection.Close();
            return IsFound;
        }
        public static bool Find(ref int UserID,string UserName, ref stUserInfo userInfo)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from Users where UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                UserID = (int)Reader["ID"];
                userInfo.PersonID = (int)Reader["PersonID"];
                userInfo.UserName = (string)Reader["UserName"];
                userInfo.Password = (string)Reader["Password"];
                userInfo.IsAdmin = (bool)Reader["IsAdmin"];

                IsFound = true;
            }
            connection.Close();
            return IsFound;
        }

        public static bool Find(ref int UserID, ref int PersonID, string UserName, string Password, ref bool IsAdmin)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from Users where UserName = @UserName and Password = @Password;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                UserID = (int)Reader["ID"];
                PersonID = (int)Reader["PersonID"];
                IsAdmin = (bool)Reader["IsAdmin"];

                IsFound = true;
            }
            connection.Close();
            return IsFound;
        }
        public static bool Login( string UserName, string Password)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select Found=1 from Users where UserName = @UserName and Password = @Password;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);
            connection.Open();

            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }


    }

}
