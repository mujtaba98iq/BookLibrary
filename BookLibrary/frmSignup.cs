using BookLibrary.MyClass;
using BookLibrary.Properties;
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
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbSetImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            rbFemale.Checked = false;
            rbMale_Click(sender, e);
        }

        private void lblFemale_Click(object sender, EventArgs e)
        {
            rbMale.Checked = false;
            rbFemale.Checked = true;
            rbMale_Click(sender, e);
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
                pbImage.ImageLocation = "C:\\Users\\mujta\\source\\repos\\C#_Disctop\\LibraryFullProject\\BookLibrary\\Icons\\"+
                    clsGloabal.Mode+"\\Woman 128.png";
            else
                pbImage.ImageLocation = "C:\\Users\\mujta\\source\\repos\\C#_Disctop\\LibraryFullProject\\BookLibrary\\Icons\\"+
                    clsGloabal.Mode+"\\Man 128.png";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbAddress.Text)
                 || string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("You must fill the informations first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pnlFirst.Visible = false;
            pnlSecond.Visible = true;
            this.Height = 380;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlSecond.Visible=false;
            pnlFirst.Visible=true;
            this.Height = 555;

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbUserName.Text)||
                string.IsNullOrEmpty(tbPassword.Text) ||
                string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                MessageBox.Show("You must fill the informations first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tbPassword.Text!=tbConfirmPassword.Text)
            {
                MessageBox.Show("Password don't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(clsUser.IsExitsByUserName(tbUserName.Text))
            {
                MessageBox.Show("UserName is already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            clsPerson person = new clsPerson();
            person.Name=tbName.Text;
            person.Email=tbEmail.Text;
            person.Phone=tbPhone.Text;
            person.Address=tbAddress.Text;
            person.DateOfBirth = DateOfBirth.Value;
            person.PersonalPicture = pbImage.ImageLocation;
            if (rbMale.Checked == true)
                person.Gendor = true;
            else
                person.Gendor = false;
            person.Save();

            clsUser user = new clsUser();
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.PersonID = person.PersonID;
            user.IsAdmin = false;
            if(user.Save())
            {
                MessageBox.Show("User Added Successfully");
                this.Close();
            }
        }

        private void frmSignup_Load(object sender, EventArgs e)
        {
            pbImage.ImageLocation = "C:\\Users\\mujta\\source\\repos\\C#_Disctop\\LibraryFullProject\\BookLibrary\\Icons\\" +
                    clsGloabal.Mode + "\\Man 128.png";
        }
    }
}
