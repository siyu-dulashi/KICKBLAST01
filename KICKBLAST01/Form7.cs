using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Xml.Linq;

namespace KICKBLAST01
{
    public partial class Form7 : Form
    {
        //OOP Encapculation
        string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";
        public Form7()
        {
            InitializeComponent();
        }


        //Registarion form
        private void btnReg_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }
        // Registration View Form
        private void btnRview_Click_1(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }
        // Traning plan Form
        private void btnTraning_Click_1(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
        // Private coaching Form
        private void btnPcoach_Click_1(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }
        // Compatition Form
        private void btnComp_Click_1(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }
        // Compatition Fee Form
        private void btnFee_Click_1(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }

        private void gunaArrow_Click_1(object sender, EventArgs e)
        {
            Form4 getStarted = new Form4();
            getStarted.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadTrainingPlans();
            LoadWeightCategories();


        }

        private void LoadTrainingPlans()
        {

        
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT PlanID, PlanName, Fee FROM TrainingPlans", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Combine PlanName + Fee for display
                dt.Columns.Add("DisplayText", typeof(string));
                foreach (DataRow row in dt.Rows)
                {
                    row["DisplayText"] = $"{row["PlanName"]} ({Convert.ToDecimal(row["Fee"]).ToString("F2")})";
                }

                cmbTrainingPlan.DataSource = dt;
                cmbTrainingPlan.DisplayMember = "DisplayText";
                cmbTrainingPlan.ValueMember = "PlanID";
                cmbTrainingPlan.SelectedIndex = -1;
            }
        }

    


        


        private void LoadWeightCategories()
        {
            cmbWeightCategory.Items.Clear();
            cmbWeightCategory.Items.Add("Heavyweight");
            cmbWeightCategory.Items.Add("Light-Heavyweight");
            cmbWeightCategory.Items.Add("Middleweight");
            cmbWeightCategory.Items.Add("Light-Middleweight");
            cmbWeightCategory.Items.Add("Lightweight");
            cmbWeightCategory.Items.Add("Flyweight");
            cmbWeightCategory.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtAid.Text) ||
    string.IsNullOrWhiteSpace(txtAname.Text) ||
    string.IsNullOrWhiteSpace(txtPassword.Text) ||
    string.IsNullOrWhiteSpace(txtAddress.Text) ||
    string.IsNullOrWhiteSpace(txtContact.Text) || // New validation
    cmbTrainingPlan.SelectedIndex == -1 ||
    cmbWeightCategory.SelectedIndex == -1 ||
    string.IsNullOrWhiteSpace(txtcurrentW.Text) ||
    (!rbMale.Checked && !rbFemale.Checked && !rbOther.Checked))
            {
                MessageBox.Show("Please fill in all fields before saving.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string contact = txtContact.Text.Trim(); // Get contact

            string athleteID = txtAid.Text.Trim();
            string fullName = txtAname.Text.Trim();
            string password = txtPassword.Text;
            DateTime dob = dtpBirth.Value;
            string gender = rbMale.Checked ? "Male" :
                            rbFemale.Checked ? "Female" :
                            rbOther.Checked ? "Other" : "";
            string address = txtAddress.Text.Trim();
            string category = cmbWeightCategory.Text;

            if (!float.TryParse(txtcurrentW.Text, out float weight))
            {
                MessageBox.Show("Please enter a valid number for weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int trainingPlanId;
            try
            {
                trainingPlanId = Convert.ToInt32(cmbTrainingPlan.SelectedValue);
            }
            catch
            {
                MessageBox.Show("Invalid training plan selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Athletes (AthleteID, FullName, Password, DateOfBirth, Gender, Contact, Address, TrainingPlanID, CurrentWeight, WeightCategory) " +
                "VALUES (@ID, @Name, @Password, @DOB, @Gender, @Contact, @Address, @PlanID, @Weight, @Category)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Contact", contact); // Add new contact 
                    cmd.Parameters.AddWithValue("@ID", athleteID);
                    cmd.Parameters.AddWithValue("@Name", fullName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@PlanID", trainingPlanId);
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Category", category);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Athlete registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Primary key violation
                        MessageBox.Show("Athlete ID already exists. Please use a unique ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAid.Text) || string.IsNullOrWhiteSpace(txtAname.Text))
            {
                MessageBox.Show("⚠ Please enter both Athlete ID and Full Name.");
                return;
            }

            string athleteID = txtAid.Text.Trim();
            string fullName = txtAname.Text.Trim();
            string password = txtPassword.Text;
            DateTime dob = dtpBirth.Value;
            string gender = rbMale.Checked ? "Male" :
                            rbFemale.Checked ? "Female" :
                            rbOther.Checked ? "Other" : "";
            string address = txtAddress.Text.Trim();
            string contact = txtContact.Text.Trim();

            // ✅ Training Plan (Get PlanID from combo box)
            if (cmbTrainingPlan.SelectedValue == null)
            {
                MessageBox.Show("❗ Please select a valid training plan.");
                return;
            }
            int trainingPlanId = Convert.ToInt32(cmbTrainingPlan.SelectedValue);

            // ✅ Weight
            if (!float.TryParse(txtcurrentW.Text.Trim(), out float weight))
            {
                MessageBox.Show("❗ Please enter a valid weight.");
                return;
            }

            string category = cmbWeightCategory.Text;
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("❗ Please select a weight category.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Athletes 
                             SET FullName = @Name, Password = @Password, DateOfBirth = @DOB, 
                                 Gender = @Gender, Contact = @Contact, Address = @Address, 
                                 TrainingPlanID = @PlanID, CurrentWeight = @Weight, WeightCategory = @Category 
                             WHERE AthleteID = @ID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", athleteID);
                    cmd.Parameters.AddWithValue("@Name", fullName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@PlanID", trainingPlanId);  // ✅ Plan ID, not name
                    cmd.Parameters.AddWithValue("@Weight", weight);
                    cmd.Parameters.AddWithValue("@Category", category);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("✅ Athlete updated successfully.");
                    else
                        MessageBox.Show("⚠ Athlete not found.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error while updating: " + ex.Message);
                }
            }
        }

    


        

        


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string athleteID = txtAid.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Athletes WHERE AthleteID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", athleteID);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Athlete deleted successfully.");
                    else
                        MessageBox.Show("Athlete not found.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting: " + ex.Message);
                }
            }
        }
        //clear form
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtAid.Clear();
            txtAname.Clear();
            txtPassword.Clear();
            dtpBirth.Value = DateTime.Now;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            rbOther.Checked = false;
            txtContact.Clear(); // Clear contact
            txtAddress.Clear();
            cmbTrainingPlan.Text = "";

            txtcurrentW.Clear();
            cmbWeightCategory.SelectedIndex = -1;
        }

       

        //Search button
        private void button1_Click(object sender, EventArgs e)
        {


       
            if (string.IsNullOrWhiteSpace(txtAid.Text) || string.IsNullOrWhiteSpace(txtAname.Text))
            {
                MessageBox.Show("⚠ Please enter both Athlete ID and Full Name.");
                return;
            }

            string athleteID = txtAid.Text.Trim();
            string fullName = txtAname.Text.Trim();

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    // Show what is being searched
                    MessageBox.Show($"Searching for:\nAthlete ID: {athleteID}\nFull Name: {fullName}");

                    // Query selects all columns including TrainingPlanID
                    string query = @"SELECT * FROM Athletes 
                             WHERE AthleteID = @AthleteID AND FullName COLLATE Latin1_General_CI_AI = @FullName";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@AthleteID", athleteID);
                    cmd.Parameters.AddWithValue("@FullName", fullName);

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Map TrainingPlanID to TrainingPlanName
                    Dictionary<int, string> trainingPlanMap = new Dictionary<int, string>()
            {
                { 1, "Beginner" },
                { 2, "Intermediate" },
                { 3, "Advanced" }
            };

                    if (reader.Read())
                    {
                        MessageBox.Show("✔ Record found. Now filling the form...");

                        txtAddress.Text = reader["Address"].ToString();
                        txtPassword.Text = reader["Password"].ToString();

                        // Parse DOB safely
                        if (DateTime.TryParse(reader["DateOfBirth"].ToString(), out DateTime dob))
                            dtpBirth.Value = dob;

                        txtContact.Text = reader["Contact"].ToString();
                        txtcurrentW.Text = reader["CurrentWeight"].ToString();
                        cmbWeightCategory.Text = reader["WeightCategory"].ToString();

                        // Gender radio buttons
                        string gender = reader["Gender"].ToString();
                        rbMale.Checked = (gender == "Male");
                        rbFemale.Checked = (gender == "Female");
                        rbOther.Checked = (gender == "Other");

                        // Get TrainingPlanID and map to Name
                        int trainingPlanID = Convert.ToInt32(reader["TrainingPlanID"]);
                        if (trainingPlanMap.ContainsKey(trainingPlanID))
                            cmbTrainingPlan.Text = trainingPlanMap[trainingPlanID];
                        else
                            cmbTrainingPlan.Text = ""; // or handle unknown plan

                        MessageBox.Show("✔ Athlete details loaded successfully.");
                    }
                    else
                    {
                        MessageBox.Show("❌ No matching athlete found.\nPlease check the exact ID and Name in the Athletes table.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠ Error: " + ex.Message);
                }
            }
        }


    }
}


        

    





    

    

