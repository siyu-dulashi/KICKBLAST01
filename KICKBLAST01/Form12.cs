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
        // Connection string - update this with your database connection
        private string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";


        public Form12()
        {
            InitializeComponent();


        }


        // Athlete Registration
        private void btnReg_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
        // Athlere Registration view
        private void btnRview_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
        //Traning Plan
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
        //Compatitions
        private void btnComp_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }
        //Monthly fee
        private void btnFee_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }
        // go previous page
        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
        //search button



        private void btnSave_Click(object sender, EventArgs e)
        {
          
            // Make sure all required fields are filled
            if (string.IsNullOrWhiteSpace(cmbAID.Text) ||
                string.IsNullOrWhiteSpace(txtAname.Text) ||
                string.IsNullOrWhiteSpace(cmbMonthNo.Text))
            {
                MessageBox.Show("Please fill in Athlete ID, Name, and Month before saving.");
                return;
            }

            // Read values from form
            string athleteID = cmbAID.Text;
            string fullName = txtAname.Text;
            string monthNo = cmbMonthNo.Text;

            decimal trainingFee = decimal.TryParse(txtMonthlyfee.Text, out var tf) ? tf : 0;
            decimal privateCoachingFee = decimal.TryParse(txtPMfee.Text, out var pf) ? pf : 0;
            decimal competitionFee = decimal.TryParse(txtComTfee.Text, out var cf) ? cf : 0;

            decimal totalFee = trainingFee + privateCoachingFee + competitionFee;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"INSERT INTO MonthlyFees 
                         (AthleteID, FullName, MonthNo, TrainingFee, PrivateCoachingFee, CompetitionFee, TotalFee)
                         VALUES 
                         (@AthleteID, @FullName, @MonthNo, @TrainingFee, @PrivateCoachingFee, @CompetitionFee, @TotalFee)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@MonthNo", monthNo);
                    cmd.Parameters.AddWithValue("@TrainingFee", trainingFee);
                    cmd.Parameters.AddWithValue("@PrivateCoachingFee", privateCoachingFee);
                    cmd.Parameters.AddWithValue("@CompetitionFee", competitionFee);
                    cmd.Parameters.AddWithValue("@TotalFee", totalFee);

                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Monthly Fee Saved Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save data.");
                    }
                }
            }
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtAname.Clear();
            cmbAID.SelectedIndex = -1;

            cmbMonthNo.SelectedIndex = -1;
            cmbMonthNo.Text = "";  //  add 

            cmbTrainingPlan.SelectedIndex = -1;
            cmbWeekFee.SelectedIndex = -1;
            txtAttendance.Clear();
            txtMonthlyfee.Clear();

            cmbOneHourFee.SelectedIndex = -1;
            txtAllHours.Clear();
            txtPMfee.Clear();

            cmbComName.SelectedIndex = -1;
            cmbComName.Text = "";  // add 

            cmbCompatitionFee.SelectedIndex = -1;
            txtComat.Clear();
            txtComTfee.Clear();

            txtTotalfee.Clear();
        }
        //Traning
        private void btnCal_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(cmbWeekFee.Text, out decimal weekFee) &&
       int.TryParse(txtAttendance.Text, out int attendance))
            {
                txtMonthlyfee.Text = (weekFee * attendance).ToString("F2");
            }
        }
        //Private tuition
        private void btnCal2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(cmbOneHourFee.Text, out decimal hourFee) &&
        int.TryParse(txtAllHours.Text, out int hours))
            {
                txtPMfee.Text = (hourFee * hours).ToString("F2");
            }
        }
        //Compatition
        private void btnCal3_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(cmbCompatitionFee.Text, out decimal comFee) &&
        int.TryParse(txtComat.Text, out int count))
            {
                txtComTfee.Text = (comFee * count).ToString("F2");
            }
        }
        //Total
        private void btnCaltotal_Click(object sender, EventArgs e)
        {
            decimal t1 = string.IsNullOrEmpty(txtMonthlyfee.Text) ? 0 : Convert.ToDecimal(txtMonthlyfee.Text);
            decimal t2 = string.IsNullOrEmpty(txtPMfee.Text) ? 0 : Convert.ToDecimal(txtPMfee.Text);
            decimal t3 = string.IsNullOrEmpty(txtComTfee.Text) ? 0 : Convert.ToDecimal(txtComTfee.Text);
            txtTotalfee.Text = (t1 + t2 + t3).ToString("F2");
        }
        //Compatition Count
        private void btnCount_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT COUNT(*) FROM CompetitionApplications WHERE AthleteID = @AthleteID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AthleteID", cmbAID.Text);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                txtComat.Text = count.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string athleteID = cmbAID.Text;
                if (string.IsNullOrWhiteSpace(athleteID))
                {
                    MessageBox.Show("Please select an Athlete ID.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                    SELECT 
                     a.FullName,
                     a.AthleteID,
                     tp.PlanName,
                     pcs.MonthNo,
                     ISNULL(pcs.Week1, 0) AS Week1,
                     ISNULL(pcs.Week2, 0) AS Week2,
                     ISNULL(pcs.Week3, 0) AS Week3,
                     ISNULL(pcs.Week4, 0) AS Week4,
                    (ISNULL(pcs.Week1, 0) + ISNULL(pcs.Week2, 0) + ISNULL(pcs.Week3, 0) + ISNULL(pcs.Week4, 0)) AS TotalHours,
                     c.Name AS CompetitionName
                    FROM Athletes a
                    LEFT JOIN TrainingPlans tp ON a.TrainingPlanID = tp.PlanID
                    LEFT JOIN PrivateCoachingSchedule_Backup pcs ON pcs.AthleteID = a.AthleteID
                    LEFT JOIN CompetitionApplications ca ON ca.AthleteID = a.AthleteID
                    LEFT JOIN Competitions c ON ca.CompetitionID = c.CompetitionID
                    WHERE a.AthleteID = @AthleteID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AthleteID", athleteID);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // Read values
                                string fullName = dr["FullName"].ToString();
                                string planName = dr["PlanName"].ToString();
                                string monthNo = dr["MonthNo"]?.ToString() ?? "";
                                string competitionName = dr["CompetitionName"]?.ToString() ?? "";

                                decimal week1 = Convert.ToDecimal(dr["Week1"]);
                                decimal week2 = Convert.ToDecimal(dr["Week2"]);
                                decimal week3 = Convert.ToDecimal(dr["Week3"]);
                                decimal week4 = Convert.ToDecimal(dr["Week4"]);
                                decimal totalHours = Convert.ToDecimal(dr["TotalHours"]);

                                // Count attended weeks
                                int attendedWeeks = 0;
                                if (week1 > 0) attendedWeeks++;
                                if (week2 > 0) attendedWeeks++;
                                if (week3 > 0) attendedWeeks++;
                                if (week4 > 0) attendedWeeks++;

                                // Set fee per week according to plan
                                decimal perWeekFee = 0m;
                                if (planName == "Beginner")
                                    perWeekFee = 250.00m;
                                else if (planName == "Intermediate")
                                    perWeekFee = 300.00m;
                                else if (planName == "Elite")
                                    perWeekFee = 350.00m;

                                // Fill fixed fees only if empty or zero
                                if (string.IsNullOrWhiteSpace(cmbOneHourFee.Text) || cmbOneHourFee.Text == "0" || cmbOneHourFee.Text == "0.00")
                                    cmbOneHourFee.Text = "90.50";

                                if (string.IsNullOrWhiteSpace(cmbCompatitionFee.Text) || cmbCompatitionFee.Text == "0" || cmbCompatitionFee.Text == "0.00")
                                    cmbCompatitionFee.Text = "220.00";
                                
                                
                                decimal totalWeekFee = attendedWeeks * perWeekFee;

                                // Calculate monthly fees based on total hours and fixed fees
                                decimal oneHourFee = Convert.ToDecimal(cmbOneHourFee.Text);
                                decimal oneHourMonthTotal = oneHourFee * totalHours;
                               

                                decimal competitionFee = Convert.ToDecimal(cmbCompatitionFee.Text);
                                decimal competitionMonthTotal = competitionFee * 1; // Adjust multiplier if needed



                                // Populate UI controls
                                txtAname.Text = fullName;
                                cmbTrainingPlan.Text = planName;
                                cmbMonthNo.Text = monthNo;
                                cmbComName.Text = competitionName;
                                txtAttendance.Text = attendedWeeks.ToString();
                                txtAllHours.Text = totalHours.ToString("F2");
                                cmbWeekFee.Text = perWeekFee.ToString("F2");
                                txtMonthlyfee.Text = totalWeekFee.ToString("F2");
                                txtPMfee.Text = oneHourMonthTotal.ToString("F2");
                                txtComTfee.Text = competitionMonthTotal.ToString("F2");

                                // After reading main data, close the reader
                                dr.Close();
                                // Now run the competition count query
                                string countQuery = "SELECT COUNT(*) FROM CompetitionApplications_Backup WHERE AthleteID = @athleteID";
                                using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                                {
                                    countCmd.Parameters.AddWithValue("@athleteID", athleteID);
                                    int compCount = (int)countCmd.ExecuteScalar();
                                    txtComat.Text = compCount.ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Athlete not found.");
                                // Optionally clear all textboxes/comboBoxes here if you want
                            }
                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    string query = "SELECT * FROM MonthlyFees"; // You can add WHERE clauses if needed
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMonthfee.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

    }
}
    

    
                  
        
    
























