using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlanTing
{
    class Date
    {
        public int Time { get; set; }
        public string Day { get; set; }

        public Date(int time, string day)
        {
            Time = time;
            Day = day;
        }
    }
}
