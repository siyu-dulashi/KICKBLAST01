using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KICKBLAST01
{
    public partial class Form9 : Form
    {
        //OOP Encapsulation
        string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";

        public Form9()
        {
            InitializeComponent();
            //attach the event handler
    this.dgvTraningPlan.CellDoubleClick += new DataGridViewCellEventHandler(dgvTraningPlan_DoubleClick);

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
        //Form load
        private void Form9_Load(object sender, EventArgs e)
        {
            LoadTrainingPlans();
            LoadPlanNames();
        }

        private void LoadTrainingPlans()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT PlanID, PlanName, Fee FROM TrainingPlans";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTraningPlan.DataSource = dt;

                cmbPlanID.DataSource = dt.Copy();
                cmbPlanID.DisplayMember = "PlanID";
                cmbPlanID.ValueMember = "PlanID";
                cmbPlanID.SelectedIndex = -1;

                dgvTraningPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        // Load pre-defined plan names
        private void LoadPlanNames()
        {
            cmbPlanName.Items.Clear();
            cmbPlanName.Items.Add("Beginner");     //Main
            cmbPlanName.Items.Add("Intermediate"); //Main
            cmbPlanName.Items.Add("Elite");        //Main
            cmbPlanName.SelectedIndex = -1;
        }
        // Add Traning Plan
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string planName = cmbPlanName.Text.Trim();
            if (!decimal.TryParse(txtPlanFee.Text, out decimal fee))
            {
                MessageBox.Show("Invalid fee format.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO TrainingPlans (PlanName, Fee) VALUES (@Name, @Fee)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", planName);
                    cmd.Parameters.AddWithValue("@Fee", fee);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Training plan added successfully.");
                    LoadTrainingPlans();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while adding: " + ex.Message);
                }
            }
        }
        //Update Traning Plan
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmbPlanID.Text, out int planID))
            {
                MessageBox.Show("Please select a valid Plan ID.");
                return;
            }

            string planName = cmbPlanName.Text.Trim();
            if (!decimal.TryParse(txtPlanFee.Text, out decimal fee))
            {
                MessageBox.Show("Invalid fee format.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE TrainingPlans SET PlanName = @Name, Fee = @Fee WHERE PlanID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", planID);
                    cmd.Parameters.AddWithValue("@Name", planName);
                    cmd.Parameters.AddWithValue("@Fee", fee);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Training plan updated.");
                    LoadTrainingPlans();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating: " + ex.Message);
                }
            }

        }
        //Delete traning plan
        private void btnDelete_Click(object sender, EventArgs e)
        {
               
            if (!int.TryParse(cmbPlanID.Text, out int planID))
            {
                MessageBox.Show("Please select a valid Plan ID.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM TrainingPlans WHERE PlanID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", planID);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Training plan deleted.");
                    LoadTrainingPlans();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting: " + ex.Message);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Encapsulated method to clear all form inputs
        private void ClearFields()
        {
            cmbPlanID.SelectedIndex = -1;
            cmbPlanName.SelectedIndex = -1;
            txtPlanFee.Clear();

        }

        private void dgvTraningPlan_DoubleClick(object sender, EventArgs e)
        {
           

            // Fill form fields manually with row data
            cmbPlanID.Text = dgvTraningPlan.CurrentRow.Cells[0].Value.ToString();
            cmbPlanName.Text = dgvTraningPlan.CurrentRow.Cells[1].Value.ToString();
            txtPlanFee.Text = dgvTraningPlan.CurrentRow.Cells[2].Value.ToString();

            // Ask user if they want to update this record
            DialogResult dr = MessageBox.Show(
                "Do you want to update this record?\nIf yes, please edit the fields and then click the Update button.",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Focus to the plan name combobox for editing
                cmbPlanName.Focus();
            }
            else
            {
                // Optional: Clear fields or do nothing if No
                // ClearFields();
            }

        }
    }
    }

        

            
        
    

        
    
                 










