using BookLibrary.Controls;
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
    public partial class frmFindPerson : Form
    {
        public delegate void DataBackEvent(int PersonID);
        public event DataBackEvent DataBack;
        public frmFindPerson()
        {
            InitializeComponent();
        }
        void GetPersonID(int PersonID)
        {
            tbSearch.Text = PersonID.ToString();
            //ctrlPersonInfo1.LoadPersonInfo(PersonID);
        }
        private void frmFindPerson_Load(object sender, EventArgs e)
        {
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            DataBack.Invoke(ctrlPersonInfo1.PersonID);
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddNewPerson frm = new frmAddNewPerson(true);
            frm.DataBack += GetPersonID;
            frm.ShowDialog();
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {
           
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                MessageBox.Show("Enter PersonID First");
                return;
            }
            if (!int.TryParse(tbSearch.Text, out int Result))
            {
                MessageBox.Show("The input must be a number");
                return;
            }
            ctrlPersonInfo1.LoadPerson(Convert.ToInt32(tbSearch.Text));
        }

     
    }
}
  