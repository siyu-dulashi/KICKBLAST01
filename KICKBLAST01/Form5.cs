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
using static System.Net.Mime.MediaTypeNames;

namespace KICKBLAST01
{
    public partial class Form5 : Form
    {
        private string sourceRole = "";//OOP: Field to track role (User/Admin)

        //OOP: Constructor initializing form controls
        public Form5()
        {
            InitializeComponent();
        }
        // OOP: Event Handler for Reset Password button

        private void guna_resrtbtn_Click(object sender, EventArgs e)  //reset password
        {
            string username = txtUname.Text.Trim();
            string newPassword = txtNew.Text.Trim();
            string confirmPassword = txtConpass.Text.Trim();

            // OOP:  validation
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("⚠ Please fill in all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("❌ New password and confirmation do not match.");
                return;
            }
            //  SQL connection ( string)
            string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    //  Check  user exists in Users table
                    string checkUser = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    SqlCommand cmdUser = new SqlCommand(checkUser, conn);
                    cmdUser.Parameters.AddWithValue("@Username", username);

                    int userCount = (int)cmdUser.ExecuteScalar();

                    if (userCount == 1)
                    {
                        string updateUser = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username";
                        SqlCommand updateCmd = new SqlCommand(updateUser, conn);
                        updateCmd.Parameters.AddWithValue("@Username", username);
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCmd.ExecuteNonQuery();
                        sourceRole = "User"; // OOP: Set user role
                        MessageBox.Show("✅ User password reset successfully!");

                        // Open User Login
                        Form3 userLogin = new Form3();
                        userLogin.Show();
                        this.Hide();
                        return;
                    }
                    //  Not found in that table
                    MessageBox.Show("⚠ Username not found in system.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error resetting password: " + ex.Message);
                }
            }
        }


         // OOP: Navigation to Signup form

        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form2 Signup = new Form2();
            Signup.Show();
            this.Hide();



        }
        // Close the application

        private void gunaClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    }
            
        

