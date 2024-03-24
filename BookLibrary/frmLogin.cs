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

namespace BookLibrary
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Enter UserName and Password first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            clsUser user=clsUser.FindUser(tbUserName.Text,tbPassword.Text);
            if (user != null)
            {
                clsGloabal.CurrentUser = user;
                tbPassword.Text = "*******";
                this.Hide();
                frmHome frm = new frmHome();
                frm.ShowDialog();
                if (!this.IsDisposed)
                {
                    frm.Dispose();
                    this.Show();
                }
            }
            else
                MessageBox.Show("Incorrect UserName or Password\ntry again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignup frm = new frmSignup();
            frm.ShowDialog();
            frm.Dispose();
            this.Show();
        }
    }
    }

