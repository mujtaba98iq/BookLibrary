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

namespace BookLibrary.Forms.People
{
    public partial class frmAddNewPerson : Form
    {
        public delegate void DataBackEvent(int PersonID);
        public event DataBackEvent DataBack;
        bool RetrunValue = false;

        enum enMode { Add,Update}
        enMode Mode = enMode.Add;
        int _PersonID;
        public frmAddNewPerson()
        {
            InitializeComponent();
            Mode = enMode.Add;
            lbMode.Text = "Add New Person";
        }
        public frmAddNewPerson(bool RetrunValue)
        {
            InitializeComponent();
            Mode = enMode.Add;
            lbMode.Text = "Add New Person";
            this.RetrunValue = RetrunValue;

        }
        public frmAddNewPerson(int PersonID)
        {
            InitializeComponent();
            Mode = enMode.Update;
            lbMode.Text = "Update Person";
            LoadPersonInfo(PersonID);
            _PersonID=PersonID;

        }
        public void LoadPersonInfo(int PersonID)
        {
            clsPerson person=clsPerson.FindPerson(PersonID);
            if(person!=null)
            {
                lbPersonID.Text = person.PersonID.ToString();
                tbName.Text = person.Name;
                tbEmail.Text = person.Email;
                tbPhone.Text = person.Phone;
                tbAddress.Text = person.Address;
                if(person.Gendor)
                {
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                }
                else
                {
                    rbFemale.Checked = true;
                    rbMale.Checked= false;
                }
                DateOfBirth.Text=person.DateOfBirth.ToString();
                pbImage.ImageLocation = person.PersonalPicture;

            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            if (RetrunValue)
                DataBack.Invoke(Convert.ToInt32(lbPersonID.Text));
            this.Close();
        }
        private void _AddNewPerson()
        {
            clsPerson person= new clsPerson();
            person.Name=tbName.Text;
            person.Address=tbAddress.Text;
            person.Email=tbEmail.Text;
            person.PersonalPicture=pbImage.ImageLocation;
            person.DateOfBirth=DateOfBirth.Value;
            person.Phone=tbPhone.Text;

            if(rbFemale.Checked)
                person.Gendor = false;
            else
                person.Gendor = true;
            if (person.Save())
            {
                lbPersonID.Text = person.PersonID.ToString();
                MessageBox.Show("Person Added Seccessfuly");
            }

            else 
                MessageBox.Show("Person Added flaier");

        }
        private void _UpdatePersonInfo()
        {
            clsPerson person = clsPerson.FindPerson(_PersonID);
            person.Name = tbName.Text;
            person.Address = tbAddress.Text;
            person.Email = tbEmail.Text;
            person.PersonalPicture = pbImage.ImageLocation;
            person.DateOfBirth = DateOfBirth.Value;
            person.Phone = tbPhone.Text;

            if (rbFemale.Checked)
                person.Gendor = false;
            else
                person.Gendor = true;
            if (person.Save())
            {
                lbPersonID.Text = person.PersonID.ToString();
                MessageBox.Show("Person Updated Seccessfuly");
                
            }

            else
                MessageBox.Show("Person Updated flaier");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text) || string.IsNullOrWhiteSpace(tbAddress.Text)
               || string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("You must fill the informations first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (Mode)
            {
                case enMode.Add:
                    _AddNewPerson();
                    break;
                case enMode.Update:
                    _UpdatePersonInfo();
                    break;
            }
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
                pbImage.ImageLocation = "C:\\Users\\mujta\\source\\repos\\C#_Disctop\\LibraryFullProject\\BookLibrary\\Icons\\" +
                    clsGloabal.Mode + "\\Woman 128.png";
            else
                pbImage.ImageLocation = "C:\\Users\\mujta\\source\\repos\\C#_Disctop\\LibraryFullProject\\BookLibrary\\Icons\\" +
                    clsGloabal.Mode + "\\Man 128.png";
        }

        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            rbFemale.Checked = false;
            rbMale.Checked = true;
            rbMale_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            rbFemale.Checked = true;
            rbMale.Checked = false;
            rbMale_Click(sender, e);
        }
    }
}
