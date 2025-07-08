using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KICKBLAST01
{
    public partial class Form10 : Form
    {
        // OOP: Encapsulation - Private connection string
        string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";

        public Form10()
        {
            InitializeComponent();
        }
        // Athlete Registration Form
        private void btnReg_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
        // Athlete Registration view
        private void btnRview_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
        //Traning plan
        private void btnTraning_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
        //Private Coaching
        private void btnPcoach_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }
        //Compatition
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
        //go to Dashboard
        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }


        private void Form10_Load(object sender, EventArgs e) // ptivate coaching 
        {

            LoadCoachIDs();
            LoadAthleteIDs();
            LoadPrivateCoachingSchedule();
        }

        // OOP: Encapsulation
        private void LoadCoachIDs()
        {
            cmbCoachID.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CoachID FROM PrivateCoaching", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbCoachID.Items.Add(reader["CoachID"].ToString());
                }
            }
        }
        // OOP: Encapsulation
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
        }

        // Auto-fill Coach Name
        private void cmbCoachID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coachID = cmbCoachID.Text;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CoachName FROM PrivateCoaching WHERE CoachID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", coachID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtCname.Text = reader["CoachName"].ToString();
                }
            }
        }

        // OOP: Encapsulation
        private void LoadPrivateCoachingSchedule()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT TuitionID AS [Coach ID], " +
                    "(SELECT CoachName FROM PrivateCoaching WHERE CoachID = TuitionID) AS [Coach Name], " +
                    "AthleteID AS [Athlete ID], Week1 AS [Hours]" +
                    " FROM PrivateCoachingSchedule", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCoaching.DataSource = dt;
                
            }
        }


        //Add details
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCoachID.SelectedIndex == -1 || cmbAID.SelectedIndex == -1 || nudHours.Value <= 0)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "INSERT INTO PrivateCoachingSchedule (AthleteID, TuitionID, Week1) VALUES (@AthleteID, @CoachID, @Hours)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AthleteID", cmbAID.Text);
                cmd.Parameters.AddWithValue("@CoachID", cmbCoachID.Text);
                cmd.Parameters.AddWithValue("@Hours", nudHours.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Schedule added.");
                LoadPrivateCoachingSchedule();
                ClearInputs(); // Polymorphism
            }

        }
        //Update  changes
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbCoachID.SelectedIndex == -1 || cmbAID.SelectedIndex == -1 || nudHours.Value <= 0)
            {
                MessageBox.Show("Please select records to update.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "UPDATE PrivateCoachingSchedule SET Week1 = @Hours WHERE AthleteID = @AthleteID AND TuitionID = @CoachID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Hours", nudHours.Value);
                cmd.Parameters.AddWithValue("@AthleteID", cmbAID.Text);
                cmd.Parameters.AddWithValue("@CoachID", cmbCoachID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Schedule updated.");
                LoadPrivateCoachingSchedule();
                ClearInputs(); // Polymorphism
            }

        }
        //Delete details
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbCoachID.SelectedIndex == -1 || cmbAID.SelectedIndex == -1)
            {
                MessageBox.Show("Select records to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "DELETE FROM PrivateCoachingSchedule WHERE AthleteID = @AthleteID AND TuitionID = @CoachID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AthleteID", cmbAID.Text);
                cmd.Parameters.AddWithValue("@CoachID", cmbCoachID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Schedule deleted.");
                LoadPrivateCoachingSchedule();
                ClearInputs(); // Polymorphism
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs(); //OOP: Encapsulation
        }

        
          private void ClearInputs()
        {
            cmbCoachID.SelectedIndex = -1;
            cmbAID.SelectedIndex = -1;
            txtCname.Clear();
            nudHours.Value = 0;
        }
    }
}
        
    

        
    

               



       


    



    



    


    





