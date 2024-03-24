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
    public partial class frmUpdateUser : Form
    {
        int _UserID;
        public frmUpdateUser(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            LoadUserInfo(userID);
        }
        void LoadUserInfo(int UserID)
        {
            clsUser user=clsUser.FindUser(UserID);
            if (user != null)
            {
                lblUserID.Text=UserID.ToString();
                tbUserName.Text=user.UserName;
                tbPassword.Text=user.Password;
                tbConfirmPassword.Text=user.Password.ToString();
                if(user.IsAdmin) 
                    chbIsAdmin.Checked=true;
                else
                    chbIsAdmin.Checked=false;

                clsPerson person = clsPerson.FindPerson(user.PersonID);
                lblPersonID.Text = person.PersonID.ToString();
                if (person != null)
                {
                    tbPersonID.Text = person.PersonID.ToString();
                    tbName.Text=person.Name;
                    tbEmail.Text=person.Email;
                    tbPhone.Text=person.Phone;
                    tbAddress.Text=person.Address;
                    pbImage.ImageLocation = person.PersonalPicture;
                    dtpDateOfBirth.Text = person.DateOfBirth.ToString();
                    if(person.Gendor)
                    {
                        rbMale.Checked = true;
                        rbFemale.Checked = false;
                    }
                    else
                    {
                        rbMale.Checked = false;
                        rbFemale.Checked = true;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbUserName.Text)|| string.IsNullOrWhiteSpace(tbPassword.Text) ||
                string.IsNullOrWhiteSpace(tbConfirmPassword.Text) || string.IsNullOrWhiteSpace(tbPhone.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbAddress.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text)   )
            {
                MessageBox.Show("Enter All Information ");
                return;
            }
            if(tbPassword.Text!=tbConfirmPassword.Text)
            {
                MessageBox.Show("THe Password DoesN't Match ");
                return;
            }
            clsPerson person = clsPerson.FindPerson(Convert.ToInt32(lblPersonID.Text));
            person.Name=tbName.Text;
            person.Address=tbAddress.Text;
            person.Email=tbEmail.Text;
            person.Phone=tbPhone.Text;
            if(rbMale.Checked)
                person.Gendor = true;
            else
                person.Gendor=false;
            person.PersonalPicture = pbImage.ImageLocation;
            person.DateOfBirth=dtpDateOfBirth.Value;

            if (person.Save())
                MessageBox.Show("Person Updated Seccessfuly");


            clsUser user = clsUser.FindUser(Convert.ToInt32(lblUserID.Text));
            user.UserName=tbUserName.Text;
            user.PersonID=Convert.ToInt32(tbPersonID.Text);
            user.Password=tbPassword.Text;
            if(chbIsAdmin.Checked)
                user.IsAdmin=true;
            else
                user.IsAdmin=false;
            if (user.Save())
                MessageBox.Show("User Updated seccesfuly");

        }

        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
