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
    public partial class frmEditBook : Form
    {
        int _BookID;
        public frmEditBook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
            LoadBookInfo();
        }
        public void LoadBookInfo()
        {
            clsBook book= clsBook.FindBook(_BookID);
            if(book != null )
            {
                tbTitle.Text = book.Title;
                tbISBN.Text = book.ISBN;
                tbGenre.Text = book.Genre;
                tbAuther.Text = book.Auther;
                tbAdditionalDetails.Text = book.AdditionalDetails;
                tbQuantity.Text = book.Quantity.ToString();
                pbBookImage.ImageLocation = book.Image;
                dpPublishDate.Text = book.PublicationDate.ToString();
            }
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            clsGloabal.BookForm.RefreshScreen();
            this.Close();
        }

      

        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbBookImage.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text) || string.IsNullOrWhiteSpace(tbAuther.Text)
              || string.IsNullOrWhiteSpace(tbISBN.Text) || string.IsNullOrWhiteSpace(tbGenre.Text)
              || string.IsNullOrWhiteSpace(tbAdditionalDetails.Text) || string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("You must fill the informations first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (pbBookImage.ImageLocation == null)
            {
                MessageBox.Show("You must pick the book image first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!short.TryParse(tbQuantity.Text, out short x))
            {
                MessageBox.Show("Quantity must be a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsBook Book = clsBook.FindBook(_BookID);

            Book.Title = tbTitle.Text;
            Book.Auther = tbAuther.Text;
            Book.ISBN = tbISBN.Text;
            Book.PublicationDate = dpPublishDate.Value;
            Book.Genre = tbGenre.Text;
            Book.AdditionalDetails = tbAdditionalDetails.Text;
            Book.Quantity = x;
            Book.Image = pbBookImage.ImageLocation;

            if (Book.Save())
                MessageBox.Show("Book Updated Successfully");
        }
    }
}
