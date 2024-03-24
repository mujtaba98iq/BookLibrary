using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsLibraryAccessLayer
{
    public class clsBooksData
    {
        public struct stBookInfo
        {
            public string Title;
            public string Auther;
            public string ISBN;
            public DateTime PublicationDate;
            public string Genre;
            public string AdditionalDetails;
            public int Quantity;
            public string Image;
        }
        public static int AddNewBook(stBookInfo bookInfo)
        {

            int ID = -1;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Insert into Books(Title, Auther, ISBN, PublicationDate, Genre,
                 AdditionalDetails, Quantity, Image) values (@Title, @Auther, @ISBN, @PublicationDate,
                 @Genre, @AdditionalDetails, @Quantity, @Image);
                 select scope_Identity();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Title", bookInfo.Title);
            command.Parameters.AddWithValue("Auther", bookInfo.Auther);
            command.Parameters.AddWithValue("ISBN", bookInfo.ISBN);
            command.Parameters.AddWithValue("PublicationDate", bookInfo.PublicationDate);
            command.Parameters.AddWithValue("Genre", bookInfo.Genre);
            command.Parameters.AddWithValue("AdditionalDetails", bookInfo.AdditionalDetails);
            command.Parameters.AddWithValue("Quantity", bookInfo.Quantity);
            command.Parameters.AddWithValue("Image", bookInfo.Image);

            connection.Open();
            object obj = command.ExecuteScalar();
            ID = Convert.ToInt32(obj);
            connection.Close();
            return ID;
        }
        public static bool UpdateBook(int BookID, stBookInfo bookInfo)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "Update Books set Title = @Title, Auther = @Auther, ISBN = @ISBN, PublicationDate = @PublicationDate, Genre = @Genre, AdditionalDetails = @AdditionalDetails, Quantity = @Quantity, Image = @Image where BookID = @BookID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);
            command.Parameters.AddWithValue("Title", bookInfo.Title);
            command.Parameters.AddWithValue("Auther", bookInfo.Auther);
            command.Parameters.AddWithValue("ISBN", bookInfo.ISBN);
            command.Parameters.AddWithValue("PublicationDate", bookInfo.PublicationDate);
            command.Parameters.AddWithValue("Genre", bookInfo.Genre);
            command.Parameters.AddWithValue("AdditionalDetails", bookInfo.AdditionalDetails);
            command.Parameters.AddWithValue("Quantity", bookInfo.Quantity);
            command.Parameters.AddWithValue("Image", bookInfo.Image);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }
        public static bool DeleteBook(int BookID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Delete from Ratings where BookID = @BookID;
                             DELETE r
                             FROM BookCoppies p
                             INNER JOIN BorrowingRecords r ON p.CoppyID = r.BookCoppyID
                             INNER JOIN books b ON p.BookID = b.BookID
                             WHERE b.BookID = @BookID;
                             Delete from BookCoppies where BookID = @BookID;
                             Delete from Books where BookID = @BookID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);

            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result > 0;
        }
        public static List<int> GetAllBooks()
        {
            List<int> ls = new List<int>();
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select BookID from Books;";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ls.Add((int)reader["BookID"]);
            }
            reader.Close();
            connection.Close();
            return ls;
        }
        public static bool IsExist(int BookID)
        {

            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = "select found = 1 from Books where BookID = @BookID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);

            connection.Open();
            int result = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return result > 0;
        }
        public static bool Find(int BookID,ref stBookInfo bookInfo)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(Settings.connectionString);
            string query = @"Select * from Books where BookID = @BookID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("BookID", BookID);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if (Reader.Read())
            {
                bookInfo.Title = (string)Reader["Title"];
                bookInfo.Auther = (string)Reader["Auther"];
                bookInfo.ISBN = (string)Reader["ISBN"]; 
                bookInfo.PublicationDate = (DateTime)Reader["PublicationDate"];
                bookInfo.Genre = (string)Reader["Genre"];
                bookInfo.AdditionalDetails = (string)Reader["AdditionalDetails"];
                bookInfo.Quantity = (int)Reader["Quantity"]; 
                bookInfo.Image = (string)Reader["Image"];

                IsFound = true;
            }
            connection.Close();
            return IsFound;
        }

    }
}
