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

namespace KICKBLAST01                       //OOP-Polymorphism method overriding
                                            
{

    public partial class Form14 : BaseAthleteViewer
    {
        // SQL connection (can be reused)
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-8NBCQ5M9\\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;");



        public Form14()//Athlete view
        {
            InitializeComponent();

            // On form load
            dgvReg.DataSource = null;
            dgvReg.Visible = false;

            txtAId.Clear();
            txtAthletename.Clear();
            txtPassword.Clear();
        }

        // POLYMORPHISM: Override method from BaseAthleteViewer
        public override void DisplayAthleteDetails(DataTable dt, DataGridView dgv)
        {
            base.DisplayAthleteDetails(dt, dgv); // Optional call to base

            // Also update TextBoxes
            txtAthletename.Text = dt.Rows[0]["AthleteName"].ToString();
            txtPassword.Text = dt.Rows[0]["Password"].ToString();
        }




        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string athleteID = txtAId.Text.Trim();

            if (string.IsNullOrEmpty(athleteID))
            {
                MessageBox.Show("Please enter an Athlete ID first.");
                return;
            }

            try
            {
                string query = @"
                SELECT 
                    A.AthleteID,
                    A.FullName AS AthleteName,
                    A.Password,
                    PC.CoachName,
                    TP.PlanName,
                    TP.WeekFee
                FROM Athletes A
                LEFT JOIN TrainingPlans TP ON A.TrainingPlanID = TP.PlanID
                LEFT JOIN (
                    SELECT PCS1.*
                    FROM PrivateCoachingSchedule PCS1
                    INNER JOIN (
                        SELECT AthleteID, MAX(ApplyID) AS MaxApplyID
                        FROM PrivateCoachingSchedule
                        GROUP BY AthleteID
                    ) LatestPCS
                    ON PCS1.AthleteID = LatestPCS.AthleteID 
                       AND PCS1.ApplyID = LatestPCS.MaxApplyID
                ) AS PCS ON A.AthleteID = PCS.AthleteID
                LEFT JOIN PrivateCoaching PC ON PCS.TuitionID = PC.CoachID
                 WHERE A.AthleteID = @AthleteID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@AthleteID", athleteID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //  Polymorphism in Action
                    DisplayAthleteDetails(dt, dgvReg);
                }
                else
                {
                    dgvReg.DataSource = null;
                    dgvReg.Visible = false;
                    txtAthletename.Clear();
                    txtPassword.Clear();
                    MessageBox.Show("No athlete found with ID: " + athleteID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading athlete info: " + ex.Message);

            }
        }

        //Nevigation buttons

        //Athlete regiatration view
        private void btnReg_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }
        //Private coaching
        private void btnPcoach_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            this.Hide();
        }
        //Competitios
        private void btnComp_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Hide();
        }
        //Comparirion Apply
        private void btnComap_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();
        }
        //Monthly fee
        private void btnFee_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();
            this.Hide();
        }
        // go to dashboard
        private void gunaArrow_Click_1(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Hide();
        }

       
    }
    }



    



    


