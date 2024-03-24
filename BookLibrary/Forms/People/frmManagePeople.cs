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

namespace BookLibrary.Forms.People
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        { 
            dgvPeople.DataSource = clsPerson.GetAllPersons();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();
            frm.ShowDialog(); 
            dgvPeople.DataSource = clsPerson.GetAllPersons();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID =Convert.ToInt32( dgvPeople.CurrentRow.Cells[0].Value);
            frmShowPerson frm = new frmShowPerson(PersonID);
            frm.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson();
            frm.ShowDialog();
            dgvPeople.DataSource = clsPerson.GetAllPersons();

        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmAddNewPerson frm= new frmAddNewPerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value)); 
            frm.ShowDialog();
            dgvPeople.DataSource = clsPerson.GetAllPersons();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsPerson.DeletePerson(Convert.ToInt32(dgvPeople.CurrentRow.Cells[0].Value)))
                MessageBox.Show("Person deleted successfully", "Done");
           dgvPeople.DataSource= clsPerson.GetAllPersons();
        }
    }
}
