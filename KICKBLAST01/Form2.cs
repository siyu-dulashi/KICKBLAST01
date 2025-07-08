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
using Guna.UI2.WinForms;

namespace KICKBLAST01
{
    public partial class Form2 : Form// Signup
    {
        //OOP Encapsulation
        // Connection string is private to this class only.
        private string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

       

         // go to previous page
        private void gunaArrow2_Click(object sender, EventArgs e)
        {
            Form4 admin = new Form4();
            admin.Show();
            this.Hide();
        }

        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form1 getStarted = new Form1();
            getStarted.Show();
            this.Hide();
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//Already have an Account
        {
            Form3 loginForm = new Form3();
            loginForm.Show();
            this.Hide();

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // collect values from user inputs
            string uname = txtUname.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pw = txtCPassword.Text.Trim();
            string role = "User"; // signup karana aya normal user wenuwata

            // validation - empty check
            if (uname == "" || email == "" || pw == "")
            {
                MessageBox.Show("⚠ Please fill all the details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // database connection eka open 
            SqlConnection con = new SqlConnection(connStr);

            try
            {
                con.Open();

                // simple insert query
                string sql = "INSERT INTO Users (Username, Email, Password, Role) VALUES (@Uname, @Email, @Pass, @Role)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Uname", uname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Pass", pw);
                cmd.Parameters.AddWithValue("@Role", role);

                // run query
                cmd.ExecuteNonQuery();

                // success message
                MessageBox.Show("✅ Signup Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // go to login form (Form3)
                Form3 login = new Form3();
                login.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                // error message if user/email already exists
                MessageBox.Show("❌ Signup Failed!\n" + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // close connection properly
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

    }
}

