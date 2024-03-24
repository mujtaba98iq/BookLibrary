using BookLibrary.Controls;
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

namespace BookLibrary.Forms.Borrowing
{
    public partial class frmManageReturns : Form
    {
        public frmManageReturns()
        {
            InitializeComponent();
        }
        public void RefreshScreen()
        {
            pnlBooks.Controls.Clear();

            List<int> ls =clsBook.GetAllBooks();
            foreach (int id in ls)
            {
                if (clsBorrowingRecord.Find(id, clsGloabal.CurrentUser.ID) != null)
                    pnlBooks.Controls.Add(new ctrlBookCard(id));
                
            }
        }

        private void frmManageReturns_Load(object sender, EventArgs e)
        {

            List<int> ls = clsBook.GetAllBooks();

            foreach (int id in ls)
            {
                if (clsBorrowingRecord.Find(id, clsGloabal.CurrentUser.ID) != null)
                    pnlBooks.Controls.Add(new ctrlBorrowedBook(id));

            }
        }
    }
}
