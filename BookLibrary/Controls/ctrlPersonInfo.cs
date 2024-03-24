using BookLibrary.MyClass;
using BookLibrary_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary.Controls
{
    public partial class ctrlPersonInfo : UserControl
    {
        public int PersonID { get; set; }
        public ctrlPersonInfo()
        {
            InitializeComponent();
            PersonID = -1;
        }
        public bool LoadPerson(int PersonID)
        {
            if (PersonID == -1)
                return false;
            clsPerson Person = clsPerson.FindPerson(PersonID);
            if (Person != null)
            {
                this.PersonID = PersonID;
                lblPersonID.Text=PersonID.ToString();
                lbName.Text = Person.Name;
                lbEmail.Text = Person.Email;
                lblAddress.Text = Person.Address;
                lbPhone.Text = Person.Phone;
                lblBirthDate.Text=Person.DateOfBirth.ToString();
                if (Person.Gendor)
                {
                    lblGendor.Text = "Meal";
                    if (Person.PersonalPicture == "")
                        pbPersonImage.ImageLocation = "C:\\Users\\mujta\\source\\repos\\C#_Disctop\\LibraryFullProject\\BookLibrary\\Icons\\" +
                    clsGloabal.Mode + "\\Man 128.png";
                    else
                        pbPersonImage.ImageLocation=Person.PersonalPicture;

                }
                else
                {
                    lblGendor.Text = "Femail";
                    if (Person.PersonalPicture == "")
                        pbPersonImage.ImageLocation = "C:\\Users\\mujta\\source\\repos\\C#_Disctop\\LibraryFullProject\\BookLibrary\\Icons\\" +
                    clsGloabal.Mode + "\\Woman 128.png";
                    else
                        pbPersonImage.ImageLocation = Person.PersonalPicture;
                }
                return true;

            }
            else
            {
                this.PersonID = -1;

                lblPersonID.Text = "???";
                lbName.Text = "???";
                lblAddress.Text = "???";
                lblBirthDate.Text = "???";
                lbPhone.Text = "???";
                lbEmail.Text = "???";
                lblGendor.Text = "???";
                pbPersonImage.ImageLocation = "C:\\Users\\mujta\\source\\repos\\C#_Disctop\\LibraryFullProject\\BookLibrary\\Icons\\" +
                    clsGloabal.Mode + "\\Man 128.png";

                return false;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbPhone_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
