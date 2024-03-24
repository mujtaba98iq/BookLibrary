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
    public partial class ctrlBookInfo : UserControl
    {
        public ctrlBookInfo()
        {
            InitializeComponent();
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }
        public void LoadBook(int BookID)
        {
            clsBook book = clsBook.FindBook(BookID);
            if (book != null)
            {
                lblBookID.Text=BookID.ToString();
                lbTitle.Text=book.Title.ToString();
                lblAuther.Text=book.Auther;
                lblGenre.Text=book.Genre;
                lblISBN.Text=book.ISBN;
                lblPublicationDate.Text=book.PublicationDate.ToString();
                lblAdditionalDetails.Text=book.AdditionalDetails;
                lblQuantity.Text=book.Quantity.ToString();
            }
            else
            {
                lblBookID.Text ="-1";
                lblAuther.Text = "???";
                lblGenre.Text = "???";
                lblISBN.Text = "???";
                lblPublicationDate.Text = "???";
                lblAdditionalDetails.Text = "???";
                lblQuantity.Text = "???";
            }
        }

        private void ctrlBookInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
