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
    public partial class frmShowPerson : Form
    {
        
        public frmShowPerson(int PersonID)
        {
            InitializeComponent();
            ctrlPersonInfo1.LoadPerson(PersonID); 
        }
     
    }
}
