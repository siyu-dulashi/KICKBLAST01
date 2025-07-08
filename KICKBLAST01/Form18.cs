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

namespace KICKBLAST01
{

    public partial class Form18 : Form
    {
        //Encapsulation
        private string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";
        public Form18()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            this.Hide();
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Hide();
        }

        private void btnComap_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();
        }

        private void btnFee_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();
            this.Hide();
        }

        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form13 Athlete = new Form13();
            Athlete.Show();
            this.Hide();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            LoadAthleteIDs();
            LoadMonthNumbers();
        }

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
        private void LoadMonthNumbers()
        {
            cmbMfeeNO.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cmbMfeeNO.Items.Add(i.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbAID.SelectedIndex == -1 || cmbMfeeNO.SelectedIndex == -1)
            {
                MessageBox.Show("⚠ Please select Athlete ID and Month No.");
                return;
            }

            string athleteID = cmbAID.Text;
            string monthNo = cmbMfeeNO.Text;

            // OOP: SqlConnection wrapped in using
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // 1. Load athlete name
                    SqlCommand nameCmd = new SqlCommand("SELECT FullName FROM Athletes WHERE AthleteID = @ID", conn);
                    nameCmd.Parameters.AddWithValue("@ID", athleteID);
                    SqlDataReader reader = nameCmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtAthletename.Text = reader["FullName"].ToString();
                    }
                    reader.Close();


                   // 2. Load fee details
                SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT AthleteID, @Name AS AthleteName, MonthNo, 
                         TrainingFee, PrivateCoachingFee, CompetitionFee, 
                         (TrainingFee + PrivateCoachingFee + CompetitionFee) AS TotalFee
                  FROM MonthlyFees 
                  WHERE AthleteID = @ID AND MonthNo = @Month", conn);

                 da.SelectCommand.Parameters.AddWithValue("@ID", athleteID);
                 da.SelectCommand.Parameters.AddWithValue("@Month", monthNo);
                 da.SelectCommand.Parameters.AddWithValue("@Name", txtAthletename.Text);

                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 dgvMonthlyview.DataSource = dt;
            }
                 catch (Exception ex)
        {
                MessageBox.Show("⚠ Error: " + ex.Message);
            }
        }
    }
}
        }
    



