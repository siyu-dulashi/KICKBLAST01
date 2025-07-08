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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        //Athlete reg
        private void btnReg_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
        //Athlete reg view
        private void btnRview_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
        //traning plan
        private void btnTraning_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
        //Private coaching
        private void btnPcoach_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }
        //Compatitions
        private void btnComp_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }
        //Monthly Fee
        private void btnFee_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }
        //Arrow to previous page
        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form4 getStarted = new Form4();
            getStarted.Show();
            this.Hide();
        }
        //reset password
        private void btnNext_Click(object sender, EventArgs e)
        {
            Form5 Resetpassword = new Form5();
            Resetpassword.Show();
            this.Hide();
        }
    }

    }

