using BookLibrary.Forms.People;
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
using System.Xml.Serialization;

namespace BookLibrary.Forms.Users
{
    public partial class frmAddNewUser : Form
    {
        public delegate void DataBackEvent(int PersonID);
        public event DataBackEvent DataBack;
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void GetPersonID(int PersonID)
        {
            ctrlPersonInfo1.LoadPerson(PersonID);
        }
     

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            frmFindPerson frm = new frmFindPerson();
            frm.DataBack += GetPersonID;
            frm.ShowDialog();
        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserName.Text) || string.IsNullOrWhiteSpace(tbPassword.Text)
                  || string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                MessageBox.Show("You must fill the informations first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Password don't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(clsUser.IsExitsByUserName(tbUserName.Text))
            {
                MessageBox.Show("UserName is already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsUser user = new clsUser();
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.PersonID = ctrlPersonInfo1.PersonID;
            user.IsAdmin=chkIsAdmin.Checked;
            if(user.Save())
                MessageBox.Show("User Added Successfully");


        }

        private void lblIsAdmin_Click(object sender, EventArgs e)
        {
          chkIsAdmin.Checked = !chkIsAdmin.Checked;
        }
    }
}
