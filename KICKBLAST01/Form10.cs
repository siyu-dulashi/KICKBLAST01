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
                    "SELECT ApplyID AS [Coach ID], " +
                    "(SELECT CoachName FROM PrivateCoaching WHERE CoachID = ApplyID) AS [Coach Name], " +
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

          
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrEmpty(txtCname.Text.Trim()))
                {
                    MessageBox.Show("Please enter Coach Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCname.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cmbCoachID.Text.Trim()))
                {
                    MessageBox.Show("Please enter Coach ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCoachID.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(cmbAID.Text.Trim()))
                {
                    MessageBox.Show("Please select Athlete ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbAID.Focus();
                    return;
                }

                // Validate hours per week
                if (nudHours.Value <= 0)
                {
                    MessageBox.Show("Please enter valid hours per week (greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudHours.Focus();
                    return;
                }

                // Get Coach ID
                int coachID;
                if (!int.TryParse(cmbCoachID.Text.Trim(), out coachID))
                {
                    MessageBox.Show("Please enter a valid Coach ID number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbCoachID.Focus();
                    return;
                }

                // Get values from form controls
                string coachName = txtCname.Text.Trim();
                string athleteID = cmbAID.Text.Trim();
                int hoursPerWeek = Convert.ToInt32(nudHours.Value);

                // Connection string - replace with your actual connection string
                string connectionString = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a transaction
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Check if this athlete already has coaching scheduled with this coach for this month
                            string checkExistingQuery = @"SELECT COUNT(*) FROM dbo.PrivateCoachingSchedule_Backup 
                                                 WHERE AthleteID = @AthleteID AND CoachID = @CoachID AND MonthNo = @MonthNo";
                            using (SqlCommand checkCmd = new SqlCommand(checkExistingQuery, connection, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@AthleteID", athleteID);
                                checkCmd.Parameters.AddWithValue("@CoachID", coachID);
                                checkCmd.Parameters.AddWithValue("@MonthNo", DateTime.Now.Month);

                                int existingRecords = (int)checkCmd.ExecuteScalar();
                                if (existingRecords > 0)
                                {
                                    MessageBox.Show("This athlete already has coaching scheduled with this coach for this month.",
                                                  "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                            // Check if coach exists in PrivateCoaching table, if not insert
                            string checkCoachQuery = "SELECT COUNT(*) FROM dbo.PrivateCoaching WHERE CoachID = @CoachID";
                            using (SqlCommand checkCmd = new SqlCommand(checkCoachQuery, connection, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@CoachID", coachID);
                                int coachExists = (int)checkCmd.ExecuteScalar();

                                if (coachExists == 0)
                                {
                                    // Insert new coach into PrivateCoaching table
                                    string insertCoachQuery = @"INSERT INTO dbo.PrivateCoaching (CoachID, CoachName, OneHourFee) 
                                                       VALUES (@CoachID, @CoachName, @OneHourFee)";
                                    using (SqlCommand insertCoachCmd = new SqlCommand(insertCoachQuery, connection, transaction))
                                    {
                                        insertCoachCmd.Parameters.AddWithValue("@CoachID", coachID);
                                        insertCoachCmd.Parameters.AddWithValue("@CoachName", coachName);
                                        insertCoachCmd.Parameters.AddWithValue("@OneHourFee", 50.00); // Default fee, adjust as needed
                                        insertCoachCmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // Update coach name if it exists (in case name was changed)
                                    string updateCoachQuery = @"UPDATE dbo.PrivateCoaching 
                                                       SET CoachName = @CoachName 
                                                       WHERE CoachID = @CoachID";
                                    using (SqlCommand updateCoachCmd = new SqlCommand(updateCoachQuery, connection, transaction))
                                    {
                                        updateCoachCmd.Parameters.AddWithValue("@CoachID", coachID);
                                        updateCoachCmd.Parameters.AddWithValue("@CoachName", coachName);
                                        updateCoachCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            // Generate new ApplyID
                            int newApplyID = 1;
                            string getMaxIdQuery = "SELECT ISNULL(MAX(ApplyID), 0) + 1 FROM dbo.PrivateCoachingSchedule_Backup";
                            using (SqlCommand maxIdCmd = new SqlCommand(getMaxIdQuery, connection, transaction))
                            {
                                newApplyID = (int)maxIdCmd.ExecuteScalar();
                            }

                            // Insert into PrivateCoachingSchedule table
                            string insertScheduleQuery = @"INSERT INTO dbo.PrivateCoachingSchedule_Backup 
                                                  (ApplyID, AthleteID, CoachID, Week1, Week2, Week3, Week4, MonthNo, TuitionID) 
                                                  VALUES (@ApplyID, @AthleteID, @CoachID, @Week1, @Week2, @Week3, @Week4, @MonthNo, @TuitionID)";

                            using (SqlCommand insertScheduleCmd = new SqlCommand(insertScheduleQuery, connection, transaction))
                            {
                                insertScheduleCmd.Parameters.AddWithValue("@ApplyID", newApplyID);
                                insertScheduleCmd.Parameters.AddWithValue("@AthleteID", athleteID);
                                insertScheduleCmd.Parameters.AddWithValue("@CoachID", coachID);
                                insertScheduleCmd.Parameters.AddWithValue("@Week1", hoursPerWeek);
                                insertScheduleCmd.Parameters.AddWithValue("@Week2", 0);
                                insertScheduleCmd.Parameters.AddWithValue("@Week3", 0);
                                insertScheduleCmd.Parameters.AddWithValue("@Week4", 0);
                                insertScheduleCmd.Parameters.AddWithValue("@MonthNo", DateTime.Now.Month);
                                insertScheduleCmd.Parameters.AddWithValue("@TuitionID", DBNull.Value);

                                insertScheduleCmd.ExecuteNonQuery();
                            }

                            // Commit the transaction
                            transaction.Commit();

                            MessageBox.Show("Private coaching record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView
                            LoadDataGridView();

                            // Clear the form
                            ClearForm();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }

        // Method to load data into DataGridView
        private void LoadDataGridView()
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";

                string query = @"SELECT 
                            pc.CoachID,
                            pc.CoachName,
                            app.AthleteID,
                            app.Week1 AS Hours
                         FROM dbo.PrivateCoaching pc
                         LEFT JOIN dbo.PrivateCoachingSchedule_Backup app ON pc.CoachID = app.CoachID
                         ORDER BY pc.CoachID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming your DataGridView is named dgvPrivateCoaching
                        dgvCoaching.DataSource = dataTable;

                        // Format column headers
                        if (dgvCoaching.Columns.Count > 0)
                        {
                            dgvCoaching.Columns["CoachID"].HeaderText = "Coach ID";
                            dgvCoaching.Columns["CoachName"].HeaderText = "Coach Name";
                            dgvCoaching.Columns["AthleteID"].HeaderText = "Athlete ID";
                            dgvCoaching.Columns["Hours"].HeaderText = "Hours";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to clear form controls
        private void ClearForm()
        {
            cmbCoachID.SelectedIndex = -1;
            txtCname.Clear();
            cmbAID.SelectedIndex = -1;
            nudHours.Value = 0;
        }

        // Form Load event to initialize DataGridView
        private void PrivateCoachingForm_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            LoadComboBoxes(); // Load dropdown data
        }

        // Method to load ComboBox data
        private void LoadComboBoxes()
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Load Coach IDs (you might want to load from a Coaches table)
                    string coachQuery = "SELECT DISTINCT CoachID FROM dbo.PrivateCoaching ORDER BY CoachID";
                    using (SqlCommand cmd = new SqlCommand(coachQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable coachTable = new DataTable();
                            coachTable.Load(reader);

                            cmbCoachID.DisplayMember = "CoachID";
                            cmbCoachID.ValueMember = "CoachID";
                            cmbCoachID.DataSource = coachTable;
                            cmbCoachID.SelectedIndex = -1;
                        }
                    }

                    // Load Athlete IDs (replace with your actual Athletes table)
                    string athleteQuery = "SELECT AthleteID FROM Athletes ORDER BY AthleteID";
                    using (SqlCommand cmd = new SqlCommand(athleteQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable athleteTable = new DataTable();
                            athleteTable.Load(reader);

                            cmbAID.DisplayMember = "AthleteID";
                            cmbAID.ValueMember = "AthleteID";
                            cmbAID.DataSource = athleteTable;
                            cmbAID.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dropdown data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "UPDATE PrivateCoachingSchedule_Backup SET Week1 = @Hours WHERE AthleteID = @AthleteID AND TuitionID = @CoachID";
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
           
            try
            {
                // Check if exactly one full row is selected
                if (dgvCoaching.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Please select a single full row to delete.");
                    return;
                }

                // Confirm with user
                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete the selected record?",
                                                             "Confirm Delete",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                if (confirmResult != DialogResult.Yes)
                    return;

                // Get the selected DataGridViewRow
                DataGridViewRow selectedRow = dgvCoaching.SelectedRows[0];

                // Extract CoachID (assumed in first column)
                object coachIdObj = selectedRow.Cells[0].Value;

                if (coachIdObj == null || coachIdObj == DBNull.Value)
                {
                    MessageBox.Show("Selected row has no valid CoachID.");
                    return;
                }

                if (!int.TryParse(coachIdObj.ToString(), out int coachId))
                {
                    MessageBox.Show("CoachID is invalid or not a number.");
                    return;
                }

                // Connection string - update as needed
                string connectionString = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sqlDelete = "DELETE FROM PrivateCoachingSchedule_Backup WHERE CoachID = @CoachID";

                    using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("@CoachID", coachId);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            // Remove from DataGridView only if DB deletion succeeded
                            dgvCoaching.Rows.Remove(selectedRow);

                            MessageBox.Show("Record deleted successfully.");

                            // Optional: clear form controls
                            cmbCoachID.Text = "";
                            txtCname.Text = "";
                            cmbAID.Text = "";
                            nudHours.Value = 0;
                        }
                        else
                        {
                            MessageBox.Show("No matching record found in the database.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during deletion: " + ex.Message);
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

        private void dgvCoaching_DoubleClick(object sender, EventArgs e)
        {
            // Fill form fields manually with row data
            cmbCoachID.Text = dgvCoaching.CurrentRow.Cells[0].Value.ToString();
            txtCname.Text = dgvCoaching.CurrentRow.Cells[1].Value.ToString();
            cmbAID.Text = dgvCoaching.CurrentRow.Cells[2].Value.ToString();
            nudHours.Text= dgvCoaching.CurrentRow.Cells[3].Value.ToString();

            // Ask user if they want to update this record
            DialogResult dr = MessageBox.Show(
                "Do you want to update this record?\nIf yes, please edit the fields and then click the Update button.",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Focus to the plan name combobox for editing
                cmbCoachID.Focus();
            }
            else
            {
                // Optional: Clear fields or do nothing if No
                // ClearFields();
            }
        }

        
    }
}
        
    

        
    

               



       


    



    



    


    





