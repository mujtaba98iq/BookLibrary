using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static clsLibraryAccessLayer.clsBorrowingRecordsData;

namespace clsLibraryAccessLayer
{
    public class clsRatingsData
    {

        public static short GetBookRate(int BookID)
        {
            short rate = -1;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select sum(Rate)/Count(*) from Ratings where BookID = @BookID;";

            SqlCommand command = new SqlCommand(query, connection);
           command.Parameters.AddWithValue("BookID", BookID);

            connection.Open();
            object obj = command.ExecuteScalar();
            if (obj != DBNull.Value)
                rate = Convert.ToInt16(obj);
            connection.Close();
            return rate;
        }

        public static short GetBookRate(int BookID, int UserID)
        {
            short rate = -1;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Select Rate from Ratings where BookID = @BookID and UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);
            command.Parameters.AddWithValue("UserID", UserID);

            connection.Open();
            object obj = command.ExecuteScalar();

            if (obj != DBNull.Value)
                rate = Convert.ToInt16(obj);

            connection.Close();


            return rate;
        }




        public static bool RateABook(int BookID, int UserID, int Rate)
        {
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"INSERT INTO Ratings
                ([BookID]
                ,[UserID]
                ,[Rate])
                VALUES
                (@BookID
                ,@UserID
                ,@Rate);";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);
            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("Rate", Rate);

            connection.Open();
            int result = command.ExecuteNonQuery();

            connection.Close();


            return result > 0;
        }



        public static bool CanRate(int BookID, int UserID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select found = 1 from Ratings where BookID = @BookID and  UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);
            command.Parameters.AddWithValue("UserID", UserID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result < 1;
        }



    }
}
