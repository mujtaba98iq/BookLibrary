using BookLibrary.Controls;
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
    public partial class frmBookLibrary : Form
    {
        public frmBookLibrary()
        {
            InitializeComponent();
        }

        private void frmBookLibrary_Load(object sender, EventArgs e)
        {
            List<int> ls =clsBook.GetAllBooks();
            foreach (int id in ls)
            {
                pnlBooks.Controls.Add(new ctrlBookCard(id));
            }
        }
        public void RefreshScreen()
        {
            pnlBooks.Controls.Clear();

            List<int> ls = clsBook.GetAllBooks();

            foreach (int id in ls)
            {
                pnlBooks.Controls.Add(new ctrlBookCard(id));
            }
        }
    }
}
