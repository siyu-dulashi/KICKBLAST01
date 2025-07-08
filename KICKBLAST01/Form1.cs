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
    public partial class Form1 : Form
    {
        // Constructor - initialize welcome screen
        

        public Form1()
        {
            InitializeComponent();
        }
        // Event: Get Started button click

        private void guna_Startbtn_Click(object sender, EventArgs e)
        {
            // OOP - Encapsulation: Form navigation is handled privately here
            Form2 registrationForm = new Form2();

            // reopen Form1 after Form2 is closed
            registrationForm.FormClosed += (s, args) => this.Show();

            // Show the registration form and hide this form
            registrationForm.Show();
            this.Hide();
             // hides Form1 (welcome)


        }
    }
}
