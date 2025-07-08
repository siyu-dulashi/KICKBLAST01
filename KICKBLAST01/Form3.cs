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
    public partial class Form3 : Form
    {
        //  OOP: Encapsulation 
        private string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }
        //form load
        private void Form3_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // hide password by default(no 0)


        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)//login button
        {
            string username = txtUname.Text.Trim();
            string password = txtPassword.Text.Trim();

            // input validation
            if (username == "" || password == "")
            {
                MessageBox.Show("⚠ Please enter username and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();

                // hardcoded query
                string sql = "SELECT Role FROM Users WHERE Username = @U AND Password = @P";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@U", username);
                cmd.Parameters.AddWithValue("@P", password);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string role = result.ToString();

                    if (role == "User")
                    {
                        MessageBox.Show("✅ Login Successful!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form13 userPage = new Form13(); // user dashboard
                        userPage.Show();
                        this.Hide();
                    }
                    else if (role == "Admin")
                    {
                        MessageBox.Show("✅ Admin Logged In!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form4 adminForm = new Form4(); // admin dashboard
                        adminForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("❌ Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("🚫 Database Error!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //show and hide password
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShow.Checked;

        }
        //back to signup
        private void gunaArrow_Click(object sender, EventArgs e)
        {
            Form2 signup = new Form2(); // go back to signup form
            signup.Show();
            this.Hide();

        }
        //exit application
        private void gunaClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //foeget password link
        private void link_Forgetpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 reset = new Form5(); // forgot password form
            reset.Show();
            this.Hide();
        }
    }
}
        
    


      

        

        
