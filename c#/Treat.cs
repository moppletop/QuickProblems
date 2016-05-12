using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickProblems_Sharp
{
    class Treat
    {
        public static bool IsTreatDay(bool weekday, bool holiday) {
            return weekday || holiday;
        }
    }
}
