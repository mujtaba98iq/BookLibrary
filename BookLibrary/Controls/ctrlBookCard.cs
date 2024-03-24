using BookLibrary.Forms.Books;
using BookLibrary.Forms.Borrowing;
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
    public partial class ctrlBookCard : UserControl
    {
        int _BookID;
        bool _IsAvailable;
        public ctrlBookCard(int id)
        {
            InitializeComponent();
            _IsAvailable=clsBookCoppies.IsBookAvailable(id);
            LoadBook(id);
        }

        private void LoadBook(int id)
        {
            clsBook book=clsBook.FindBook(id);
            if (book != null)
            {
                this._BookID = id;
                pbBookImage.ImageLocation=book.Image;
                lblAvailable.Text = book.Auther;
                Rate.Value = clsRating.GetBookRate(id);
                lbTitle.Text = book.Title;

                if (_IsAvailable)
                {
                    lblAvailable.Text = "Available ";
                    lblAvailable.Location = new Point(105, 0);
                    lblAvailable.ForeColor = Color.DodgerBlue;
                }
                else
                {
                    lblAvailable.Text = "Not Available ";
                    lblAvailable.Location = new Point(75, 0);
                    lblAvailable.ForeColor = Color.Red;
                }
            }
            
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBook frm = new frmShowBook(_BookID);
            frm.ShowDialog();

        }

        private void ctrlBookCard_Load(object sender, EventArgs e)
        {
          
            
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewBorrow frm=new frmNewBorrow(_BookID);
            frm.ShowDialog();
            
        }

        private void showDetalisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowBook frm= new frmShowBook(_BookID);
            frm.ShowDialog();
        }

        private void ctrlBookCard_Load_1(object sender, EventArgs e)
        {
            if (clsGloabal.CurrentUser.IsAdmin)
                this.ContextMenuStrip = cmsAdmin;
            else
                this.ContextMenuStrip = cmsUser;
        }

        private void borrowToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmNewBorrow frm = new frmNewBorrow(_BookID);
            frm.ShowDialog();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want to Delete This Book?", "Delete Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsBook.DeleteBook(_BookID);
                clsGloabal.BookForm.RefreshScreen();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditBook frm = new frmEditBook(_BookID);
            frm.ShowDialog();
        }
    }
}
