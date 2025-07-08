using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KICKBLAST01
{
    

        public class BaseAthleteViewer : Form// OOP polimorphism- virtual method
        {
            public virtual void DisplayAthleteDetails(DataTable dt, DataGridView dgv)
            {
                dgv.DataSource = dt;
                dgv.Visible = true;
            }
        }
    }


