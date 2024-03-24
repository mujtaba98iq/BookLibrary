using BookLibrary.Forms.Books;
using BookLibrary.Forms.Borrowing;
using BookLibrary_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.MyClass
{
    public class clsGloabal
    {
       static public clsUser CurrentUser;
        public static string Mode = "LightMode";
        public static frmBookLibrary BookForm;
        public static frmManageReturns ReturnsForm;

        public static int DefaultBorrowDays = 3;
        public static int DefaultFinePerDay = 5;

        public static Color BaseColor = Color.White;
        public static Color SecondColor = Color.LightGray;

    }
}
