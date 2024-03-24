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

namespace BookLibrary.Forms.Users
{
    public partial class frmManageUsers : Form
    {
        
        public frmManageUsers()
        {
            InitializeComponent();
            dgvUsers.DataSource =clsUser.GetAllUsers();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm=new frmAddNewUser();
            frm.ShowDialog();
            dgvUsers.DataSource = clsUser.GetAllUsers();

        }

        private void showUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUser frm = new frmShowUser(Convert.ToInt32( dgvUsers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateUser frm=new frmUpdateUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value));
            frm.ShowDialog();
            dgvUsers.DataSource = clsUser.GetAllUsers();

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsUser.DeleteUser(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value)))
                MessageBox.Show("User deleted successfully", "Done");
            dgvUsers.DataSource=clsUser.GetAllUsers();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewUser frm= new frmAddNewUser();
            frm.ShowDialog();
            dgvUsers.DataSource =clsUser.GetAllUsers();
        }
    }
}
