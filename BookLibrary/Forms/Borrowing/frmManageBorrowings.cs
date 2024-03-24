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
    public partial class frmManageBorrowings : Form
    {
        public frmManageBorrowings()
        {
            InitializeComponent();
            dgvBorrowings.DataSource = clsBorrowingRecord.GetAllBorrowingRecord();
        }
    }
}
