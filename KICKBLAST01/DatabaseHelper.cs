using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KICKBLAST01
{
    //  OOP: Polymorphism via Interface Implementation
    public class PrivateCoachingSaver : IScheduleSaver
    {
        private string connStr = @"Data Source=LAPTOP-8NBCQ5M9\SQLEXPRESS02;Initial Catalog=KickBlastJudoDB;Integrated Security=True;";

        public void SaveSchedule(string applyId, string athleteId, string tuitionId, string oneHourFee, decimal w1, decimal w2, decimal w3, decimal w4)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO PrivateCoachingSchedule (ApplyID, AthleteID, TuitionID, OneHourFee, Week1, Week2, Week3, Week4) " +
                    "VALUES (@ApplyID, @AthleteID, @TuitionID, @OneHourFee, @W1, @W2, @W3, @W4)", conn);

                cmd.Parameters.AddWithValue("@ApplyID", applyId);
                cmd.Parameters.AddWithValue("@AthleteID", athleteId);
                cmd.Parameters.AddWithValue("@TuitionID", tuitionId);
                cmd.Parameters.AddWithValue("@OneHourFee", oneHourFee);
                cmd.Parameters.AddWithValue("@W1", w1);
                cmd.Parameters.AddWithValue("@W2", w2);
                cmd.Parameters.AddWithValue("@W3", w3);
                cmd.Parameters.AddWithValue("@W4", w4);

                cmd.ExecuteNonQuery();
                MessageBox.Show("✅ Schedule saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }



}










