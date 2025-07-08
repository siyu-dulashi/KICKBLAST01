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
    public partial class Form4 : Form// Adminform
    {
        //OOP Encapsulation - logic inside the class and methods
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Hide the password field
            txtPassword.UseSystemPasswordChar = true;

            // OOP:  admin creation on first load
            string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Check if admin already exists
                string check = "SELECT COUNT(*) FROM Admin";
                SqlCommand checkCmd = new SqlCommand(check, conn);
                int exists = (int)checkCmd.ExecuteScalar();

                if (exists == 0)
                {
                    // Insert default admin if not present
                    string insert = "INSERT INTO Admin (AdminID, Password) VALUES ('admin123', 'adminpass')";// after rest password (1010)
                    SqlCommand insertCmd = new SqlCommand(insert, conn);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        

        
       
      
        // Login Button  opens Form5
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string adminID = txtAid.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate fields
            if (string.IsNullOrEmpty(adminID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("⚠ Please enter both Admin ID and Password.");
                return;
            }

            // OOP: Database Connection - coded connection
            string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Admin WHERE AdminID = @ID AND Password = @PW";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", adminID);
                    cmd.Parameters.AddWithValue("@PW", password);

                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("✅ Login successful! Welcome Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form6 dashboard = new Form6(); // Admin dashboard
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("❌ Invalid Admin credentials.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }


        }

        private void gunaArrow_Click(object sender, EventArgs e)//go to signup page
        {
            Form2 signUp = new Form2();
            signUp.Show();
            this.Hide();
        }

        private void gunaClose_Click(object sender, EventArgs e)//Colse button to exit
        {
            Application.Exit();
        }

        //  password visibility

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;
        }
        //Forget Password option
        private void link_Forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 Resetpassword = new Form5();
            Resetpassword.Show();
            this.Hide();
        }
        

    }
    }



