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

    public partial class Form17 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-8NBCQ5M9\\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;");
        public Form17()
        {
            InitializeComponent();
            
        }
        

        private void btnReg_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }

        private void btnPcoach_Click(object sender, EventArgs e)
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbApplyID.SelectedIndex = -1;
            cmbAthleteID.SelectedIndex = -1;
            cmbComID.SelectedIndex = -1;
            cmbPlanID.SelectedIndex = -1;
            cmbAllowplan.SelectedIndex = -1;
            txtWeight.Clear();
            txtPname.Clear();
            txtWeightc.Clear();
            txtPaidfee.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = @"UPDATE CompetitionApplications_Backup SET 
                         CompetitionID = @CompetitionID,
                         AthleteID = @AthleteID,
                         TrainingPlanID = @TrainingPlanID,
                         CurrentWeightCategory = @WeightCategory,
                         AllowPlan = @AllowPlan
                         WHERE ApplicationID = @ApplicationID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CompetitionID", cmbComID.Text);
                cmd.Parameters.AddWithValue("@AthleteID", cmbAthleteID.Text);
                cmd.Parameters.AddWithValue("@TrainingPlanID", cmbPlanID.Text);
                cmd.Parameters.AddWithValue("@WeightCategory", txtWeightc.Text);
                bool allowValue = (cmbAllowplan.Text == "Yes");
                cmd.Parameters.AddWithValue("@AllowPlan", allowValue);
                cmd.Parameters.AddWithValue("@ApplicationID", cmbApplyID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Application updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating application: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void btnApply_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO CompetitionApplications_Backup 
                    (CompetitionID, AthleteID, TrainingPlanID, CurrentWeightCategory, AllowPlan)
                    VALUES (@CompetitionID, @AthleteID, @TrainingPlanID, @WeightCategory, @AllowPlan)", con);

                cmd.Parameters.AddWithValue("@CompetitionID", cmbComID.Text);
                cmd.Parameters.AddWithValue("@AthleteID", cmbAthleteID.Text);
                cmd.Parameters.AddWithValue("@TrainingPlanID", cmbPlanID.Text);
                cmd.Parameters.AddWithValue("@WeightCategory", txtWeightc.Text);
                bool allowValue = (cmbAllowplan.Text == "Yes");
                cmd.Parameters.AddWithValue("@AllowPlan", allowValue);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Your application has been processed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (txtPname.Text == "Beginner")
            {
                cmbAllowplan.SelectedItem = "Not Allowed"; // or just clear it
                MessageBox.Show("Sorry, Beginner can’t apply for competition.");
            }
            else
            {
                cmbAllowplan.SelectedItem = "Allowed";
                MessageBox.Show("Application allowed please click Apply .");
            }

        }
    }
    }
    
    

    

