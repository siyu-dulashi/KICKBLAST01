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
    public partial class Form15 : Form
    {
        string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";
        IScheduleSaver saver = new PrivateCoachingSaver();  //  OOP: Polymorphism


        public Form15()
        {
            InitializeComponent();

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            LoadAthleteIDs();
            LoadTuitionIDs();
            LoadLatestSavedSchedule();
        }

        private void LoadAthleteIDs()
        {
            cmbAId.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT AthleteID FROM Athletes", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    cmbAId.Items.Add(reader["AthleteID"].ToString());
            }
        }

        private void LoadTuitionIDs()
        {
            cmbTId.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CoachID FROM PrivateCoaching", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    cmbTId.Items.Add(reader["CoachID"].ToString());
            }
        }

            


        private void btnReg_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//private coaching
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {


                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO PrivateCoachingSchedule ( AthleteID, ApplyID, Week1, Week2, Week3, Week4) " +
                        "VALUES ( @AthleteID, @ApplyID, @W1, @W2, @W3, @W4)", conn);

                    
                    cmd.Parameters.AddWithValue("@AthleteID", cmbAId.Text);
                    cmd.Parameters.AddWithValue("@ApplyID", cmbTId.Text);
                    cmd.Parameters.AddWithValue("@W1", numW1.Value);
                    cmd.Parameters.AddWithValue("@W2", numW2.Value);
                    cmd.Parameters.AddWithValue("@W3", numW3.Value);
                    cmd.Parameters.AddWithValue("@W4", numW4.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Schedule saved.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving: " + ex.Message);
                }

            }
        }


        private void LoadLatestSavedSchedule()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM PrivateCoachingSchedule ORDER BY ApplyID DESC", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cmbApplyID.Text = reader["ApplyID"].ToString();
                    cmbAId.Text = reader["AthleteID"].ToString();
                    cmbTId.Text = reader["TuitionID"].ToString();
                    
                    numW1.Value = Convert.ToDecimal(reader["Week1"]);
                    numW2.Value = Convert.ToDecimal(reader["Week2"]);
                    numW3.Value = Convert.ToDecimal(reader["Week3"]);
                    numW4.Value = Convert.ToDecimal(reader["Week4"]);
                    txtTHours.Text = (numW1.Value + numW2.Value + numW3.Value + numW4.Value).ToString();
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string appID = cmbApplyID.Text;
            string athleteID = cmbAId.Text;
            string tuitionID = cmbTId.Text;
            

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "INSERT INTO PrivateCoachingSchedule ( AthleteID, ApplyID) " +
                               "VALUES ( @athleteID, @tuitionID)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    
                    cmd.Parameters.AddWithValue("@athleteID", athleteID);
                    cmd.Parameters.AddWithValue("@ApplyID", tuitionID);
                    

                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(result > 0 ? "Updated successfully!" : "Update failed.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbApplyID.SelectedIndex = -1;
            cmbAId.SelectedIndex = -1;
            cmbTId.SelectedIndex = -1;
            txtOnehfee.Clear();
            numW1.Value = 0;
            numW2.Value = 0;
            numW3.Value = 0;
            numW4.Value = 0;
            txtTHours.Clear();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal total = numW1.Value + numW2.Value + numW3.Value + numW4.Value;
            txtTHours.Text = total.ToString();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbTId.SelectedIndex == -1)
                return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmdFee = new SqlCommand("SELECT OneHourFee FROM PrivateCoaching WHERE CoachID = @CID", conn);
                cmdFee.Parameters.AddWithValue("@CID", cmbTId.Text);
                SqlDataReader reader = cmdFee.ExecuteReader();
                if (reader.Read())
                    txtOnehfee.Text = reader["OneHourFee"].ToString();
            }

        }
    }
}



       

       