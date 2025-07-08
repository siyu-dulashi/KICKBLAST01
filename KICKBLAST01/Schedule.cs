using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KICKBLAST01
{
    //  OOP: Polymorphism via Interface
    public interface IScheduleSaver
    {
        void SaveSchedule(string applyId, string athleteId, string tuitionId, string oneHourFee, decimal w1, decimal w2, decimal w3, decimal w4);


    }
}

