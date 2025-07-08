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
    public partial class Form12 : Form
    {
        // Encapsulation: connection string is hidden from other classes
        private string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";


        public Form12()
        {
            InitializeComponent();
            LoadMonthlyFees(); // autoload table
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

        // Training Fee Calculation

        private void btnCal_Click(object sender, EventArgs e)//cal1
        {
            if (cmbAID.SelectedIndex == -1 || cmbMonthID.SelectedIndex == -1)
            {
                MessageBox.Show("⚠ Please select Athlete ID and Month No.");
                return;
            }

            if (cmbTId.SelectedIndex == -1 || txtWeekfee.Text == "" || txtAttendance.Text == "")
            {
                MessageBox.Show("⚠ Fill all Training Plan fields first.");
                return;
            }

            decimal weekFee = Convert.ToDecimal(txtWeekfee.Text);
            int attendance = Convert.ToInt32(txtAttendance.Text);
            txtMonthlyfee.Text = (weekFee * attendance).ToString("0.00");
        }

        private void btnCal2_Click(object sender, EventArgs e)
        {
            if (cmbTuitionID.SelectedIndex == -1 || txtOhf.Text == "" || txtAllHours.Text == "")
            {
                MessageBox.Show("⚠ Fill all Private Tuition fields.");
                return;
            }

            decimal oneHourFee = Convert.ToDecimal(txtOhf.Text);
            int hours = Convert.ToInt32(txtAllHours.Text);
            txtPMfee.Text = (oneHourFee * hours).ToString("0.00");
        }

        private void btnCal3_Click(object sender, EventArgs e)
        {

            if (cmbAID.SelectedIndex == -1)
            {
                MessageBox.Show("⚠ Please select Athlete ID first.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Join CompetitionApplications and Competitions to get SUM of actual fees
                SqlCommand cmd = new SqlCommand(@"
            SELECT SUM(C.Fee)
            FROM CompetitionApplications A
            JOIN Competitions C ON A.CompetitionID = C.CompetitionID
            WHERE A.AthleteID = @AthleteID", conn);

                cmd.Parameters.AddWithValue("@AthleteID", cmbAID.Text);

                object result = cmd.ExecuteScalar();
                decimal totalCompetitionFee = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                txtComF.Text = "220.00"; // show this just as a fixed per-entry value (your display label)
                txtComTfee.Text = totalCompetitionFee.ToString("0.00"); // actual total fee from competitions
            }

        }

        private void btnCaltotal_Click(object sender, EventArgs e)//Total
        {
            {
                decimal trainingFee = txtMonthlyfee.Text != "" ? Convert.ToDecimal(txtMonthlyfee.Text) : 0;
                decimal privateFee = txtPMfee.Text != "" ? Convert.ToDecimal(txtPMfee.Text) : 0;
                decimal compFee = txtComTfee.Text != "" ? Convert.ToDecimal(txtComTfee.Text) : 0;

                txtTotalfee.Text = (trainingFee + privateFee + compFee).ToString("0.00");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbAID.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtMonthlyfee.Text) ||// traning
       string.IsNullOrWhiteSpace(txtPMfee.Text) || string.IsNullOrWhiteSpace(txtComTfee.Text))//private
            {
                MessageBox.Show("⚠ Please fill all required fee sections before saving.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"INSERT INTO MonthlyFees (AthleteID, TrainingFee, PrivateCoachingFee, CompetitionFee)
                             VALUES (@AthleteID, @TrainFee, @PrivateFee, @CompetitionFee)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AthleteID", cmbAID.Text);
                    cmd.Parameters.AddWithValue("@TrainFee", Convert.ToDecimal(txtMonthlyfee.Text));
                    cmd.Parameters.AddWithValue("@PrivateFee", Convert.ToDecimal(txtPMfee.Text));
                    cmd.Parameters.AddWithValue("@CompetitionFee", Convert.ToDecimal(txtComTfee.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Monthly fee record saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadMonthlyFees(); // Reload DataGridView if applicable
                }
            }
            catch (Exception ex)

            {
                {
                        MessageBox.Show("Error saving: " + ex.Message);
                    
                }
            }
        }
        private void LoadMonthlyFees()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MonthlyFees", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMonthfee.DataSource = dt;
            }
        }
       

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbAID.SelectedIndex = -1;
            cmbMonthID.SelectedIndex = -1;
            cmbTId.SelectedIndex = -1;
            cmbTuitionID.SelectedIndex = -1;
            cmbComAId.SelectedIndex = -1;
            cmbAthId.SelectedIndex = -1;
            

            txtTplan.Clear();
            txtWeekfee.Clear();
            txtAttendance.Clear();
            txtMonthlyfee.Clear();

            txtOhf.Clear();
            txtAllHours.Clear();
            txtPMfee.Clear();

            txtComF.Clear();
            txtComat.Clear();
            txtComTfee.Clear();
            txtTotalfee.Clear();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (cmbAID.SelectedIndex == -1)
            {
                MessageBox.Show("⚠ Please select Athlete ID before counting competitions.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-8NBCQ5M9\\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;"))
                {
                    string athleteID = cmbAID.Text;

                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM CompetitionApplications WHERE AthleteID = @AthleteID", con);
                    cmd.Parameters.AddWithValue("@AthleteID", athleteID);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar();
                    con.Close();

                    txtComat.Text = count.ToString();

                    decimal entryFee = 220.00m; //  fee per competition
                    txtComTfee.Text = (count * entryFee).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error counting competitions: " + ex.Message);
            }

        }
    }
}


    


    
    

