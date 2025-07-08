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
    public partial class Form16 : Form
    {
        private string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";

        public Form16()
        {
            InitializeComponent();
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

        private void Form16_Load(object sender, EventArgs e)
        {
            LoadCompetitionIDs();
            LoadAllCompetitions(); // Load  at start

        }
        private void LoadCompetitionIDs()
        {
            cmbComId.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CompetitionID FROM Competitions", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbComId.Items.Add(reader["CompetitionID"].ToString());
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbComId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Competition ID.");
                return;
            }

            int competitionID = Convert.ToInt32(cmbComId.SelectedItem.ToString());
            LoadCompetitionsByID(competitionID);
        }

        private void LoadCompetitionsByID(int compID)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT 
                                    CompetitionID,
                                    Name,
                                    Fee,
                                    WeightCategory,
                                    CompetitionDate,
                                    CompetitionTime,
                                    220.00 AS EntryFee
                                FROM Competitions
                                WHERE CompetitionID = @ID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@ID", compID);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCom.DataSource = dt;
            }
        }

        private void LoadAllCompetitions()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT 
                                    CompetitionID,
                                    Name,
                                    Fee,
                                    WeightCategory,
                                    CompetitionDate,
                                    CompetitionTime,
                                    220.00 AS EntryFee
                                FROM Competitions";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCom.DataSource = dt;
            }
        }
    }
}
    


