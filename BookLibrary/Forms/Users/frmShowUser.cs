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
    public partial class frmShowUser : Form
    {
        public frmShowUser(int UserID)
        {
            InitializeComponent();
            LoadUserID(UserID);


        }
        void LoadUserID(int UserID)
        {
            clsUser user = clsUser.FindUser(UserID);
            if (user != null)
            {
                int PersonID = user.PersonID;
                ctrlPersonInfo1.LoadPerson(PersonID);

                lblUserID.Text=UserID.ToString();
                lblUserName.Text=user.UserName;
                lblIsAdmin.Text = user.IsAdmin.ToString();
            }
        }
    }
}
