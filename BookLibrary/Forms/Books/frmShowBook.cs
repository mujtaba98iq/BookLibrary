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

namespace BookLibrary.Forms.Books
{
    public partial class frmShowBook : Form
    {
        int _BookID=-1;
        bool _CanRate;
        public frmShowBook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
            ctrlBookInfo1.LoadBook(_BookID);
            BookRate.Value = clsRating.GetBookRate(_BookID);
            YourRate.Value=clsRating.GetBookRate(_BookID,clsGloabal.CurrentUser.ID);
            _CanRate = clsRating.CanRate(_BookID, clsGloabal.CurrentUser.ID);
            MessageBox.Show(_CanRate.ToString());
        }

        private void frmShowBook_Load(object sender, EventArgs e)
        {
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_CanRate && YourRate.Value!=0)
            {
                clsRating.RateABook(_BookID, clsGloabal.CurrentUser.ID, YourRate.Value);
                clsGloabal.BookForm.RefreshScreen();
            }
            this.Close();
        }
    }
}
