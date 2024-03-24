using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace clsLibraryAccessLayer
{
    public class clsBookCoppiesData
    {

        public static bool AddBookCoppies(int BookID, short Quantity)
        {

            int ID;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Insert into BookCoppies(BookID, IsAvailable) values (@BookID, 1);";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);
            connection.Open();

            int result = 0;
            for (short i = 0; i < Quantity; i++)
            {
                result = command.ExecuteNonQuery();
            }


            connection.Close();
            return result > 0;
        }

        public static bool UpdateBookCoppy(int CoppyID, int BookID, bool IsAvailable)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Update BookCoppies set BookID = @BookID, IsAvailable = @IsAvailable where CoppyID = @CoppyID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("CoppyID", CoppyID);
            command.Parameters.AddWithValue("BookID", BookID);
            command.Parameters.AddWithValue("IsAvailable", IsAvailable);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public static bool DeleteBookCoppy(int CoppyID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Delete from BookCoppies where CoppyID = @CoppyID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("CoppyID", CoppyID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public static DataTable GetAllBookCoppies()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from BookCoppies;";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
                dt.Load(reader);
            reader.Close();
            connection.Close();
            return dt;
        }

        public static bool IsExist(int CoppyID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select found = 1 from BookCoppies where CoppyID = @CoppyID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("CoppyID", CoppyID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }

        public static bool Find(int CoppyID, ref int BookID, ref bool IsAvailable)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from BookCoppies where CoppyID = @CoppyID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("CoppyID", CoppyID);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                BookID = (int)Reader["BookID"];
                IsAvailable = (bool)Reader["IsAvailable"];

                IsFound = true;
            }
            connection.Close();
            return IsFound;
        }

        public static bool IsBookAvailable(int BookID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select found = 1 from BookCoppies where BookID = @BookID and IsAvailable = 1;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }

        public static int GetTopAvailableCoppy(int BookID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select top 1 CoppyID from BookCoppies where BookID = @BookID and IsAvailable = 1;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return result;
        }

        public static bool SetAsUnAvailable(int CoppyID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Update BookCoppies set IsAvailable = 0 where CoppyID = @CoppyID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("CoppyID", CoppyID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();

            return result > 0;
        }
        public static bool SetAsAvailable(int CoppyID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Update BookCoppies set IsAvailable = 1 where CoppyID = @CoppyID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("CoppyID", CoppyID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();

            return result > 0;
        }


    }

}
