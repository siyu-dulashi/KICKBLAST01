using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KICKBLAST01
{
    public partial class Form8 : Form
    {
        //OOP Encapsulation
        string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";

        public Form8()
        {
            InitializeComponent();
        }

        //Athlete registration Form
        private void btnReg_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
        // Registration View Form
        private void btnRview_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
        // Traning plan Form
        private void btnTraning_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
        // Private Coaching Form
        private void btnPcoah_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }
        // Compatition Form
        private void btnComp_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }
        // Monthly Fee Form
        private void btnFee_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }
        //go to previous form- dashboard
        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)// Athlete Registration View
        {
            LoadAthleteIDs();
            LoadAthletes();
            dgvRegview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // OOP: Encapsulation used in LoadAthleteIDs and LoadAthletes methods
        private void LoadAthleteIDs()
        {
            cmbAID.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT AthleteID FROM Athletes", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbAID.Items.Add(reader["AthleteID"].ToString());
                }
            }

            cmbAID.SelectedIndex = -1;
        }
        private void LoadAthletes()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();     // athlete name=Full name(sql)
                string query = @"SELECT AthleteID, FullName, Password, DateOfBirth, Gender, Contact, Address, 
                                        TrainingPlanID, CurrentWeight, WeightCategory 
                                 FROM Athletes";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRegview.DataSource = dt;
                dgvRegview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbAID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Athlete ID.");
                return;
            }

            string selectedID = cmbAID.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT AthleteID, FullName, Password, DateOfBirth, Gender, Contact, Address, 
                                        TrainingPlanID, CurrentWeight, WeightCategory 
                                 FROM Athletes 
                                 WHERE AthleteID = @ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", selectedID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRegview.DataSource = dt;
                dgvRegview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }

}
    



