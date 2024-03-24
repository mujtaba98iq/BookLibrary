using clsLibraryAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_BusinessLayer
{
    public class clsBorrowingRecord
    {
        enum en_Mode
        {
            eAdd, eUpdate
        }
        en_Mode _Mode = en_Mode.eAdd;
        public int BorrowingRecordID { get; set; }
        public int UserID { get; set; }
        public int BookCoppyID { get; set; }
        public DateTime BorrowingDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ActualReturnDate { get; set; }

        public clsBorrowingRecord() 
        { 
            BorrowingRecordID = -1;
            UserID = -1;
            BookCoppyID = -1;
            BorrowingDate= DateTime.MinValue;
            DueDate = DateTime.MinValue;
            ActualReturnDate = DateTime.MinValue;
            _Mode = en_Mode.eAdd;
        }
        public clsBorrowingRecord(int borrowingRecordID, int userID, int bookCoppyID, DateTime borrowingDate, DateTime dueDate, DateTime actualReturnDate)
        {
            this.BorrowingRecordID = borrowingRecordID;
            this.UserID = userID;
            this.BookCoppyID = bookCoppyID;
            this.BorrowingDate = borrowingDate;
            this.DueDate = dueDate;
            this.ActualReturnDate = actualReturnDate;
            _Mode= en_Mode.eUpdate;
        }
        private bool _AddNewBorrowingRecord()
        {
            clsBorrowingRecordsData.stBorrowingInfo borrowingInfo = new clsBorrowingRecordsData.stBorrowingInfo();
            borrowingInfo.UserID = UserID;
            borrowingInfo.BookCoppyID=BookCoppyID;
            borrowingInfo.BorrowingDate= BorrowingDate;
            borrowingInfo.DueDate = DueDate;
            borrowingInfo.ActualReturnDate=ActualReturnDate;
            this.BorrowingRecordID=clsBorrowingRecordsData.AddNewBorrowingRecord(borrowingInfo);
            return this.BorrowingRecordID != 0;
        }
        private bool _UpdateBorrowingRecord()
        {
            clsBorrowingRecordsData.stBorrowingInfo borrowingInfo = new clsBorrowingRecordsData.stBorrowingInfo();
            return clsBorrowingRecordsData.UpdateBorrowingRecord(this.BorrowingRecordID, borrowingInfo);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case en_Mode.eAdd:
                    if (_AddNewBorrowingRecord())
                    {
                        _Mode = en_Mode.eUpdate;
                        return true;
                    }
                    else
                        return false;
                case en_Mode.eUpdate:
                    if (_UpdateBorrowingRecord())
                        return true;
                    else
                        return false;
            }
            return false;
        }
        static public bool UpdateReturnDate(int BorrowingRecordID, DateTime ActualReturnDate)
        {
            return clsBorrowingRecordsData.UpdateReturnDate(BorrowingRecordID, ActualReturnDate);
        }
        static public bool IsThisUserHaveThisBook(int BookID, int UserID)
        {
            return clsBorrowingRecordsData.IsThisUserHaveThisBook(BookID, UserID);
        }
        static public bool DeleteBorrowingRecord(int BorrowingRecordID)
        {
            return clsBorrowingRecordsData.DeleteBorrowingRecord(BorrowingRecordID);
        }
        static public DataTable GetAllBorrowingRecord()
        {
            return clsBorrowingRecordsData.GetAllBorrowingRecord();
        }
        public static clsBorrowingRecord Find(int BookID, int UserID)
        {
            int BookCoppyID = -1;
            int BorrowingRecordID = -1;
            DateTime BorrowingDate = DateTime.Now;
            DateTime DueDate = DateTime.Now;
            DateTime ActualReturnDate = DateTime.MinValue;

            bool IsFound = clsBorrowingRecordsData.Find(BookID, UserID, ref BorrowingRecordID, ref BookCoppyID, ref BorrowingDate, ref DueDate, ref ActualReturnDate);

            if (IsFound)
                return new clsBorrowingRecord(BorrowingRecordID, BookCoppyID, UserID, BorrowingDate, DueDate, ActualReturnDate);
            else return null;
        }
        public static clsBorrowingRecord Find(int BorrowingRecordID)
        {
            clsBorrowingRecordsData.stBorrowingInfo borrowingInfo = new clsBorrowingRecordsData.stBorrowingInfo();

            if (clsBorrowingRecordsData.Find(BorrowingRecordID,ref borrowingInfo))
                return new clsBorrowingRecord(BorrowingRecordID, borrowingInfo.UserID, borrowingInfo.BookCoppyID,
                    borrowingInfo.BorrowingDate,borrowingInfo.DueDate,borrowingInfo.ActualReturnDate);
            else
                return null;
        }
        
    }
}
