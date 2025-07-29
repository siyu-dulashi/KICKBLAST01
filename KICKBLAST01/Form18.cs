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
        // Athlete registration view
        private void btnReg_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.Show();
            this.Hide();
        }
        //Traning plan
        private void button3_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            this.Hide();
        }
        //Compatition view
        private void btnComp_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Hide();
        }
        //Competition application view
        private void btnComap_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            this.Hide();
        }
        //MOnthly fee view
        private void btnFee_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            form18.Show();
            this.Hide();
        }
        //go to previous form
        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form13 Athlete = new Form13();
            Athlete.Show();
            this.Hide();
        }
        //Load event for Form18
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
            if (string.IsNullOrWhiteSpace(cmbAID.Text) || string.IsNullOrWhiteSpace(txtAthletename.Text))
            {
                MessageBox.Show("⚠ Please enter Athlete ID and Full Name.");
                return;
            }

            string athleteID = cmbAID.Text.Trim();
            string athleteName = txtAthletename.Text.Trim();


            try
            {
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    string query = @"
                SELECT AthleteID, @Name AS AthleteName, MonthNo, 
                       TrainingFee, PrivateCoachingFee, CompetitionFee, 
                       (TrainingFee + PrivateCoachingFee + CompetitionFee) AS TotalFee
                FROM MonthlyFees
                WHERE AthleteID = @ID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@ID", athleteID);
                    adapter.SelectCommand.Parameters.AddWithValue("@Name", athleteName);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvMonthlyview.DataSource = dt;
                    }
                    else
                    {
                        dgvMonthlyview.DataSource = null;
                        MessageBox.Show("⚠ No matching records found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠ Error: " + ex.Message);
            }
        }

    }

    }











        
    



