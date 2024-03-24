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

namespace BookLibrary
{
    public partial class frmManageFines : Form
    {
        public frmManageFines()
        {
            InitializeComponent();
        }

        private void frmManageFines_Load(object sender, EventArgs e)
        {
            dgvFines.DataSource = clsFine.GetAllFines();
        }

        private void setAsPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsFine.SetAsPaid(Convert.ToInt32(dgvFines.CurrentRow.Cells[0].Value));
            dgvFines.DataSource = clsFine.GetAllFines();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsFine.DeleteFine(Convert.ToInt32(dgvFines.CurrentRow.Cells[0].Value));
            dgvFines.DataSource=clsFine.GetAllFines();
        }
    }
}
