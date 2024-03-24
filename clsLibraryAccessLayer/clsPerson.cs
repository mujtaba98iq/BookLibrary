using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static clsLibraryAccessLayer.clsPersonData;

namespace clsLibraryAccessLayer
{
    public class clsPersonData
    {
        public struct stPersonInfo
        {
            public string Name;
            public string Email;
            public string Phone;
            public DateTime DateOfBirth;
            public bool Gendor;
            public string Address;
            public string PersonalPicture;
        }


        public static int AddNewPerson(stPersonInfo PersonInfo)
        {

            int ID;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Insert into Person(Name, Email, Phone, DateOfBirth, Gendor, Address, PersonalPicture) values (@Name, @Email, @Phone, @DateOfBirth, @Gendor, @Address, @PersonalPicture);select scope_Identity();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Name",PersonInfo.Name);
            if (string.IsNullOrWhiteSpace(PersonInfo.Email))
                command.Parameters.AddWithValue("Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("Email", PersonInfo.Email);
            command.Parameters.AddWithValue("Phone", PersonInfo.Phone);
            command.Parameters.AddWithValue("DateOfBirth", PersonInfo.DateOfBirth);
            command.Parameters.AddWithValue("Gendor", PersonInfo.Gendor);
            command.Parameters.AddWithValue("Address", PersonInfo.Address);
            command.Parameters.AddWithValue("PersonalPicture", PersonInfo.PersonalPicture);

            connection.Open();
            object obj = command.ExecuteScalar();
            ID = Convert.ToInt32(obj);
            connection.Close();
            return ID;
        }

        public static bool UpdatePerson(int PersonID, stPersonInfo PersonInfo)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Update Person set Name = @Name, Email = @Email, Phone = @Phone,
            DateOfBirth = @DateOfBirth, Gendor = @Gendor, Address = @Address, 
            PersonalPicture = @PersonalPicture where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", PersonID);
            command.Parameters.AddWithValue("Name", PersonInfo.Name);
            if (string.IsNullOrWhiteSpace(PersonInfo.Email))
                command.Parameters.AddWithValue("Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("Email", PersonInfo.Email);

            command.Parameters.AddWithValue("Phone", PersonInfo.Phone);
            command.Parameters.AddWithValue("DateOfBirth", PersonInfo.DateOfBirth);
            command.Parameters.AddWithValue("Gendor", PersonInfo.Gendor);
            command.Parameters.AddWithValue("Address", PersonInfo.Address);
            command.Parameters.AddWithValue("PersonalPicture", PersonInfo.PersonalPicture);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public static bool DeletePerson(int PersonID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Delete from Person where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", PersonID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public static DataTable GetAllPerson()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"SELECT   PersonID, Name, Email, Phone, DateOfBirth,case 
                             when Gendor = 0 then 'Female'
                             when Gendor = 1 then 'Male'
                             end as Gendor, Address, PersonalPicture
                             FROM         Person;";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
                dt.Load(reader);
            reader.Close();
            connection.Close();
            return dt;
        }

        public static bool IsExist(int PersonID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select found = 1 from Person where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", PersonID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }

        public static bool Find(int PersonID, ref stPersonInfo PersonInfo)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from Person where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", PersonID);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                PersonInfo.Name = (string)Reader["Name"];
                if (Reader["Email"] != DBNull.Value)
                    PersonInfo.Email = (string)Reader["Email"];
                PersonInfo.Phone = (string)Reader["Phone"];
                PersonInfo.DateOfBirth = (DateTime)Reader["DateOfBirth"];
                PersonInfo.Gendor = (bool)Reader["Gendor"];
                PersonInfo.Address = (string)Reader["Address"];
                PersonInfo.PersonalPicture = (string)Reader["PersonalPicture"];

                IsFound = true;
            }
            connection.Close();
            return IsFound;
        }


    }
}
