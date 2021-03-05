using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ExpInfo
    {
        public double InsertTime { get; set; } = 0;
        public double InreaseTime { get; set; } = 0;
        public double ExtraxtMaxTime { get; set; } = 0;

        public ExpInfo(double insertTime, double inreaseTime, double extraxtMaxTime)
        {
            InsertTime = insertTime;
            InreaseTime = inreaseTime;
            ExtraxtMaxTime = extraxtMaxTime;
        }

        public ExpInfo()
        {
        }
    }
}
