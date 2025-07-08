using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KICKBLAST01
{
    public partial class Form13 : Form
    {
        // OOP: Inheritance - using NavigationHandler
        FormNavigator navigator = new FormNavigator();


        public Form13()
        {
            InitializeComponent();
        }

        

        
        
        //Athlete Registration
        private void btnReg_Click(object sender, EventArgs e)
        {
            navigator.Navigate(this, new Form14()); // OOP: Inheritance

        }
        //Private coaching
        private void btnPcoach_Click(object sender, EventArgs e)
        {
            navigator.Navigate(this, new Form15()); // OOP: Inheritance

        }
        //Compatitions
        private void btnComp_Click(object sender, EventArgs e)
        {
            navigator.Navigate(this, new Form16()); // OOP: Inheritance
        }
        //Compatition Apply
        private void btnComap_Click(object sender, EventArgs e)
        {
            navigator.Navigate(this, new Form17()); // OOP: Inheritance
        }
        //Monthly Fee
        private void btnFee_Click(object sender, EventArgs e)
        {
            navigator.Navigate(this, new Form18()); // OOP: Inheritance

        }

        private void gunaArrow_Click(object sender, EventArgs e)
        {
            navigator.Navigate(this, new Form3()); // OOP: Inheritance
        }
    }
    }
