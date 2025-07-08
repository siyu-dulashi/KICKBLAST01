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

    
    public partial class Form11 : Form
    {
        // OOP: Encapsulation
        private string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";
       

        public Form11()
        {
            InitializeComponent();
        }
        // Navigation Buttons

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

        private void Form11_Load(object sender, EventArgs e)
        {
            LoadWeightCategories();
            LoadCompetitions();
            
        }

        private void LoadWeightCategories()
        {
            cmbComw.Items.Clear();
            cmbComw.Items.AddRange(new string[]
            {
                "Heavyweight", "Light-Heavyweight", "Middleweight",
                "Light-Middleweight", "Lightweight", "Flyweight"
            });
            cmbComw.SelectedIndex = -1;
        }

        private void LoadCompetitions()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Competitions", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCompetitions.DataSource = dt;
                // Load Competition IDs to ComboBox
                cmbComId.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmbComId.Items.Add(row["CompetitionID"].ToString());
                }
            }
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtComfee.Text.Trim(), out decimal fee))
            {
                MessageBox.Show("Invalid fee amount.");
                return;
            }

            if (!TimeSpan.TryParse(txtTime.Text.Trim(), out TimeSpan compTime))
            {
                MessageBox.Show("Invalid time format. Use HH:mm (e.g., 14:30).");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Competitions (Name, Fee, WeightCategory, CompetitionDate, CompetitionTime)
                                     VALUES (@Name, @Fee, @Category, @Date, @Time)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtComname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Fee", fee);
                    cmd.Parameters.AddWithValue("@Category", cmbComw.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpCom.Value.Date);
                    cmd.Parameters.AddWithValue("@Time", compTime);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Competition added successfully.");
                    LoadCompetitions();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding competition: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmbComId.Text.Trim(), out int compID))
            {
                MessageBox.Show("Please select a valid Competition ID.");
                return;
            }

            if (!decimal.TryParse(txtComfee.Text.Trim(), out decimal fee) ||
                !TimeSpan.TryParse(txtTime.Text.Trim(), out TimeSpan compTime))
            {
                MessageBox.Show("Invalid input.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Competitions SET 
                                     Name = @Name, Fee = @Fee, WeightCategory = @Category, 
                                     CompetitionDate = @Date, CompetitionTime = @Time
                                     WHERE CompetitionID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txtComname.Text.Trim());
                    cmd.Parameters.AddWithValue("@Fee", fee);
                    cmd.Parameters.AddWithValue("@Category", cmbComw.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpCom.Value.Date);
                    cmd.Parameters.AddWithValue("@Time", compTime);
                    cmd.Parameters.AddWithValue("@ID", compID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Competition updated successfully.");
                    LoadCompetitions();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating competition: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmbComId.Text.Trim(), out int compID))
            {
                MessageBox.Show("Please select a valid Competition ID to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Competitions WHERE CompetitionID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", compID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Competition deleted successfully.");
                    LoadCompetitions();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting competition: " + ex.Message);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();// OOP: Encapsulation

        }
        private void ClearInputs()
        {
            cmbComId.SelectedIndex = -1;
            txtComname.Clear();
            txtComfee.Clear();
            cmbComw.SelectedIndex = -1;
            dtpCom.Value = DateTime.Today;
            txtTime.Clear();
        }
    }
}
            




















