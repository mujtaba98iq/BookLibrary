using BookLibrary.MyClass;
using BookLibrary_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary.Controls
{
    public partial class ctrlBorrowedBook : UserControl
    {
        int _BorrowingID;
        int _CoppyID;
        DateTime _DueDate;

        int _BookID;
        public ctrlBorrowedBook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
            LoadBookInfo(_BookID);
        }
        public void LoadBookInfo(int BookID)
        {
            clsBorrowingRecord record = clsBorrowingRecord.Find(_BookID, clsGloabal.CurrentUser.ID) ;
            if(record != null)
            {
                _BorrowingID = record.BorrowingRecordID;
                _CoppyID = record.BookCoppyID;

                lbBorrowDate.Text = record.BorrowingDate.ToString("dd/MM/yyyy");
                lbDueDate.Text = record.DueDate.ToString("dd/MM/yyyy");
                _DueDate = record.DueDate; 

                if (record.DueDate < DateTime.Now)
                {
                    TimeSpan difference = DateTime.Now - record.DueDate;
                    lbLateDays.Text = difference.Days.ToString();
                }
            }
            clsBook Book =clsBook.FindBook(BookID);
            if (Book != null)
            {
                lbTitle.Text = Book.Title;
                lbAuther.Text = Book.Auther;
                pbImage.ImageLocation = Book.Image; 
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            clsBorrowingRecord.UpdateReturnDate(_BorrowingID, DateTime.Now);
            clsBookCoppies.SetAsAvailable(_CoppyID);
            if(_DueDate<DateTime.Now)
            {
                TimeSpan diffrence=DateTime.Now - _DueDate;
                int days=diffrence.Days;
                MessageBox.Show("You are " + days + " days late\nWe will charge you: " + days * clsGloabal.DefaultFinePerDay + " USD");

                clsFine fine = new clsFine();
                fine.UserID = clsGloabal.CurrentUser.ID;
                fine.NumberOfLateDays = Convert.ToInt16(lbLateDay.Text);
                fine.BorrowingRecordID = _BorrowingID;
                fine.FineAmount = days * clsGloabal.DefaultFinePerDay;
                fine.PaymentStatus = false;
                fine.Save();
            }
            else
            {
                MessageBox.Show("Book return successfully with now extra fine");
            }
            clsGloabal.ReturnsForm.RefreshScreen();
        }
    }
}
