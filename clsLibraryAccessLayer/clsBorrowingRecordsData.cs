using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static clsLibraryAccessLayer.clsBooksData;
using System.Net;

namespace clsLibraryAccessLayer
{
    public class clsBorrowingRecordsData
    {

        public struct stBorrowingInfo
        {
            public int BookCoppyID;
            public int UserID;
            public DateTime BorrowingDate;
            public DateTime DueDate;
            public DateTime ActualReturnDate;
        }


        public static int AddNewBorrowingRecord(stBorrowingInfo borrowingInfo)
        {

            int ID = -1;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"INSERT INTO [dbo].[BorrowingRecords]
           ([UserID]
           ,[BookCoppyID]
           ,[BorrowingDate]
           ,[DueDate]
           ,[ActualReturnDate])
            VALUES
           (@UserID
           ,@BookCoppyID
           ,@BorrowingDate
           ,@DueDate
           ,@ActualReturnDate);
		   select scope_Identity();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", borrowingInfo.UserID);
            command.Parameters.AddWithValue("BookCoppyID", borrowingInfo.BookCoppyID);
            command.Parameters.AddWithValue("BorrowingDate", borrowingInfo.BorrowingDate);
            command.Parameters.AddWithValue("DueDate", borrowingInfo.DueDate);
            if (borrowingInfo.ActualReturnDate == DateTime.MinValue)
                command.Parameters.AddWithValue("ActualReturnDate", DBNull.Value);

            connection.Open();
            object obj = command.ExecuteScalar();
            ID = Convert.ToInt32(obj);
            connection.Close();
            return ID;
        }
        public static bool UpdateBorrowingRecord(int BorrowingRecordID, stBorrowingInfo borrowingInfo)
        {
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"UPDATE [dbo].[BorrowingRecords]
           SET [UserID] = @UserID
            ,[BookCoppyID] = @BookCoppyID
          ,[BorrowingDate] = @BorrowingDate
          ,[DueDate] = @DueDate
          ,[ActualReturnDate] = @ActualReturnDate
           WHERE BorrowingRecordID=@BorrowingRecordID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BorrowingRecordID", BorrowingRecordID);
            command.Parameters.AddWithValue("UserID",borrowingInfo.UserID);
            command.Parameters.AddWithValue("BookCoppyID",  borrowingInfo.BookCoppyID);
            command.Parameters.AddWithValue("BorrowingDate",  borrowingInfo.BorrowingDate);
            command.Parameters.AddWithValue("DueDate", borrowingInfo.DueDate);
            if (borrowingInfo.ActualReturnDate == DateTime.MinValue)
                command.Parameters.AddWithValue("ActualReturnDate", DBNull.Value);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public static bool UpdateReturnDate(int BorrowingRecordID,DateTime ActualReturnDate)
        {
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"UPDATE [dbo].[BorrowingRecords]
           SET [ActualReturnDate] = @ActualReturnDate
           WHERE BorrowingRecordID=@BorrowingRecordID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BorrowingRecordID", BorrowingRecordID);
            command.Parameters.AddWithValue("ActualReturnDate", ActualReturnDate);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }

        public static bool IsThisUserHaveThisBook(int BookID, int UserID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"select found = 1 from BookCoppies 
                             INNER JOIN Books ON BookCoppies.BookID = Books.BookID
                             INNER JOIN BorrowingRecords ON BookCoppies.CoppyID = BorrowingRecords.BookCoppyID
                             where BorrowingRecords.UserID = @UserID and Books.BookID = @BookID and ActualReturnDate is null; ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);
            command.Parameters.AddWithValue("UserID", UserID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }

        public static bool DeleteBorrowingRecord(int BorrowingRecordID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Delete from BorrowingRecords where BorrowingRecordID = @BorrowingRecordID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BorrowingRecordID", BorrowingRecordID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }


        public static DataTable GetAllBorrowingRecord()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from BorrowingRecords;";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
                dt.Load(reader);
            reader.Close();
            connection.Close();
            return dt;
        }

        public static bool IsExist(int BorrowingRecordID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select found = 1 from BorrowingRecords where BorrowingRecordID = @BorrowingRecordID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BorrowingRecordID", BorrowingRecordID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }
        public static bool Find(int BookID, int UserID, ref int BorrowingRecordID, ref int BookCoppyID, ref DateTime BorrowingDate, ref DateTime DueDate, ref DateTime ActualReturnDate)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"SELECT BorrowingRecords.* FROM BookCoppies 
                             INNER JOIN Books ON BookCoppies.BookID = Books.BookID
                             INNER JOIN BorrowingRecords ON BookCoppies.CoppyID = BorrowingRecords.BookCoppyID
                             where BorrowingRecords.UserID = @UserID and Books.BookID = @BookID and ActualReturnDate is null;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);
            command.Parameters.AddWithValue("UserID", UserID);


            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                BorrowingRecordID = (int)Reader["BorrowingRecordID"];
                BookCoppyID = (int)Reader["BookCoppyID"];
                BorrowingDate = (DateTime)Reader["BorrowingDate"];
                DueDate = (DateTime)Reader["DueDate"];

                IsFound = true;
            }
            connection.Close();
            return IsFound;
        }
        public static bool Find(int BorrowingRecordID, ref stBorrowingInfo borrowingInfo)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"SELECT BorrowingRecords.* FROM BookCoppies 
                             INNER JOIN Books ON BookCoppies.BookID = Books.BookID
                             INNER JOIN BorrowingRecords ON BookCoppies.CoppyID = BorrowingRecords.BookCoppyID
                             where BorrowingRecords.UserID = @UserID and
                             Books.BookID = @BookID and ActualReturnDate is null;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BorrowingRecordID", BorrowingRecordID);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                borrowingInfo.BookCoppyID = (int)Reader["BookCoppyID"];
                borrowingInfo.UserID = (int)Reader["UserID"];
                borrowingInfo.BorrowingDate = (DateTime)Reader["BorrowingDate"];
                borrowingInfo.DueDate = (DateTime)Reader["DueDate"];
                borrowingInfo.ActualReturnDate = (DateTime)Reader["ActualReturnDate"];

                IsFound = true;
            }
            connection.Close();
            return IsFound;
        }
    }

}
