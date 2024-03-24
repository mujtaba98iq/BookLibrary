using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static clsLibraryAccessLayer.clsBorrowingRecordsData;

namespace clsLibraryAccessLayer
{
    public class clsFinesData
    {
        public struct stFineInfo
        {
            public int UserID;
            public int BorrowingRecordID;
            public short NumberOfLateDays;
            public decimal FineAmount;
            public bool PaymentStatus;
        }
        public static int AddNewFine(stFineInfo fineInfo)
        {

            int ID = -1;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"INSERT INTO [dbo].[Fines]
                 ([UserID]
                 ,[BorrowingRecordID]
                 ,[NumberOfLateDays]
                 ,[FineAmount]
                 ,[PaymentStatus])
                  VALUES
                 (@UserID
                 ,@BorrowingRecordID
                 ,@NumberOfLateDays
                 ,@FineAmount
                 ,@PaymentStatus)
                 select scope_Identity();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", fineInfo.UserID);
            command.Parameters.AddWithValue("BorrowingRecordID", fineInfo.BorrowingRecordID);
            command.Parameters.AddWithValue("NumberOfLateDays", fineInfo.NumberOfLateDays);
            command.Parameters.AddWithValue("FineAmount", fineInfo.FineAmount);
            command.Parameters.AddWithValue("PaymentStatus", fineInfo.PaymentStatus);

            connection.Open();
            object obj = command.ExecuteScalar();
            ID = Convert.ToInt32(obj);
            connection.Close();
            return ID;
        }
        public static bool UpdateFine(int FineID, stFineInfo fineInfo)
        {
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"UPDATE [dbo].[Fines]
                  SET [UserID] = @UserID
                 ,[BorrowingRecordID] =@BorrowingRecordID
                 ,[NumberOfLateDays] = @NumberOfLateDays
                 ,[FineAmount] = @FineAmount
                 ,[PaymentStatus] = @PaymentStatus
                 WHERE FineID=@FineID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", fineInfo.UserID);
            command.Parameters.AddWithValue("BorrowingRecordID", fineInfo.BorrowingRecordID);
            command.Parameters.AddWithValue("NumberOfLateDays", fineInfo.NumberOfLateDays);
            command.Parameters.AddWithValue("FineAmount", fineInfo.FineAmount);
            command.Parameters.AddWithValue("PaymentStatus", fineInfo.PaymentStatus);
          

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }
        public static bool DeleteFine(int FineID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Delete from Fines where FineID = @FineID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("FineID", FineID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }
        public static bool SetAsPaid(int FineID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Update Fines set PaymentStatus = 1 where FineID = @FineID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("FineID", FineID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }
        public static DataTable GetAllFines()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"select * from FullInfoForFines;";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
                dt.Load(reader);
            reader.Close();
            connection.Close();
            return dt;
        }
        public static bool IsExist(int FineID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select found = 1 from Fines where FineID = @FineID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("FineID", FineID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }

        public static bool Find(int FineID, ref stFineInfo fineInfo)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from Fines where FineID = @FineID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("FineID", FineID);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                fineInfo.UserID = (int)Reader["UserID"];
                fineInfo.BorrowingRecordID = (int)Reader["BorrowingRecordID"];
                fineInfo.NumberOfLateDays = (short)Reader["NumberOfLateDays"];
                fineInfo.FineAmount = (decimal)Reader["FineAmount"];
                fineInfo.PaymentStatus = (bool)Reader["PaymentStatus"];

                IsFound = true;
            }
            connection.Close();
            return IsFound;
        }
    }
}
