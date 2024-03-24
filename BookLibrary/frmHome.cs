using BookLibrary.MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using BookLibrary_BusinessLayer;
using BookLibrary.Forms.Books;
using BookLibrary.Forms.Borrowing;
using BookLibrary.Forms.People;
using BookLibrary.Forms.Users;

namespace BookLibrary
{
    public partial class frmHome : Form
    {
        Button PreviousButton;
        private UserPreferenceChangedEventHandler _userPreferenceChanged;
        public frmHome()
        {
            InitializeComponent();
            LoadTheme();
            _userPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += _userPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
        }
        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= _userPreferenceChanged;
        }
        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }
        private void LoadTheme()
        {
            var themeColor = WinThemes.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);
            pnlHeader.BackColor = themeColor;
            pnlSideBar.BackColor = lightColor;
            //btnAddNewBook.IdleFillColor = lightColor;
            //btnLogout.IdleFillColor = lightColor;
            //panelLine.BackColor = lightColor;
            //rjCircularPictureBox1.BorderColor = themeColor;
            //rjCircularPictureBox1.BorderColor2 = darkColor;
            //labelVersion.ForeColor = lightColor;
            //rjButton7.BackColor = darkColor;
            //Buttons
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = themeColor;
            }
            foreach (Button button in this.pnlHeader.Controls.OfType<Button>())
            {
                button.FlatAppearance.MouseOverBackColor = themeColor;
                button.FlatAppearance.MouseDownBackColor = lightColor;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            if(clsGloabal.CurrentUser.IsAdmin)
            {
                btnBorrowings.Visible = true;
                btnFines.Visible = true;
                btnUsers.Visible = true;
                btnPeople.Visible = true;
                btnAddNewBook.Visible = true;
            }
            PreviousButton = btnBooks;
            clsPerson person = clsPerson.FindPerson(clsGloabal.CurrentUser.PersonID);
            lbName.Text = person.Name;
            pbPersonImage.ImageLocation = person.PersonalPicture;
            btnBooks_Click(sender, e);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            PreviousButton.BackColor = clsGloabal.SecondColor;
            PreviousButton = btnBooks;
            btnBooks.BackColor = Color.White;

            frmBookLibrary frm= new frmBookLibrary();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
                
            clsGloabal.BookForm = frm;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
            PreviousButton.BackColor = clsGloabal.SecondColor;
            PreviousButton = btnMyBooks;
            btnMyBooks.BackColor = Color.White;
            
            frmManageReturns frm = new frmManageReturns();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            clsGloabal.ReturnsForm=frm;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            PreviousButton.BackColor = clsGloabal.SecondColor;
            PreviousButton = btnPeople;
            btnPeople.BackColor = Color.White;

            frmManagePeople frm = new frmManagePeople();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;


            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            PreviousButton.BackColor = clsGloabal.SecondColor;
            PreviousButton = btnUsers;
            btnUsers.BackColor = Color.White;

            frmManageUsers frm = new frmManageUsers();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;


            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
            PreviousButton.BackColor = clsGloabal.SecondColor;
            PreviousButton = btnBorrowings;
            btnBorrowings.BackColor = Color.White;

            frmManageBorrowings frm = new frmManageBorrowings();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;


            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();

        }

        private void btnFines_Click(object sender, EventArgs e)
        {
            PreviousButton.BackColor= clsGloabal.SecondColor;
            PreviousButton = btnFines;
            btnFines.BackColor = Color.White;
            
            frmManageFines frm = new frmManageFines();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(frm);
            frm.Show();
        }
    }
}
