using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KICKBLAST01
{
    public partial class Form12 : Form
    {


        public Form12()
        {
            InitializeComponent();


        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void btnRview_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void btnTraning_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }

        private void btnPcoach_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }

        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

            }
            }























