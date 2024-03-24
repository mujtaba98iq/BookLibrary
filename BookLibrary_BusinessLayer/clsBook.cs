using clsLibraryAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_BusinessLayer
{
    public class clsBook
    {
        public enum enMode { AddNew, Update };
        public enMode Mode;
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Auther { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Genre { get; set; }
        public string AdditionalDetails { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }

       public clsBook ()
        {
            BookID = -1;
            Title = string.Empty;
            Auther = string.Empty;
            ISBN = string.Empty;
            PublicationDate = DateTime.MinValue;
            Genre = string.Empty;
            AdditionalDetails = string.Empty;
            Quantity = 0;
            Image = string.Empty;
            Mode = enMode.AddNew;

        }
        public clsBook (int ID,string Title,string Auther,string ISBN,DateTime PublicationDate,
            string Genre,string AdditionalDetails,int Quantity,string Image)
        {
            this.BookID = ID;
            this.Title = Title;
            this.Auther = Auther;
            this.ISBN = ISBN;
            this.PublicationDate = PublicationDate;
            this.Genre = Genre;
            this.AdditionalDetails = AdditionalDetails;
            this.Quantity = Quantity;
            this.Image = Image;
            Mode = enMode.Update;

        }

        private bool _AddNewBook()
        {
            clsBooksData.stBookInfo bookInfo = new clsBooksData.stBookInfo();
           bookInfo.Title = Title;
            bookInfo.Auther = Auther;
            bookInfo.ISBN = ISBN;
            bookInfo.PublicationDate = PublicationDate;
            bookInfo.Genre = Genre;
            bookInfo.AdditionalDetails = AdditionalDetails;
            bookInfo.Quantity = Quantity;
            bookInfo.Image = Image;


            this.BookID = clsBooksData.AddNewBook(bookInfo);
            return this.BookID != -1;
        }
        private bool _UpdateBook()
        {
            clsBooksData.stBookInfo bookInfo = new clsBooksData.stBookInfo();
            bookInfo.Title = Title;
            bookInfo.Auther = Auther;
            bookInfo.ISBN = ISBN;
            bookInfo.PublicationDate = PublicationDate;
            bookInfo.Genre = Genre;
            bookInfo.AdditionalDetails = AdditionalDetails;
            bookInfo.Quantity = Quantity;
            bookInfo.Image = Image;
            return clsBooksData.UpdateBook(this.BookID, bookInfo);

        }
        static public bool DeleteBook(int ID)
        {
            return clsBooksData.DeleteBook(ID);
        }
        static public bool IsExitsByID(int ID)
        {
            return clsBooksData.IsExist(ID);
        }
        static public clsBook FindBook(int ID)
        {
            clsBooksData.stBookInfo bookInfo = new clsBooksData.stBookInfo();
            if (clsBooksData.Find(ID, ref bookInfo))
                return new clsBook(ID, bookInfo.Title, bookInfo.Auther, bookInfo.ISBN,
                    bookInfo.PublicationDate,bookInfo.Genre, bookInfo.AdditionalDetails,
                    bookInfo.Quantity,bookInfo.Image);
            else
                return null;
        }
        static public List<int> GetAllBooks()
        {
            return clsBooksData.GetAllBooks();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBook())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    if (_UpdateBook())
                        return true;
                    else
                        return false;
            }
            return false;
        }
    }
}
