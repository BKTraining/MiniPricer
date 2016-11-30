using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPricer_csharp
{
    public class WorkingDay : IWorkingDay
    {
        public int GetWorkingDay(DateTime start, DateTime end)
        {
            int duration = (end - start).Days;
            int result = 0;
            for(int i = 0;i<=duration;i++)
            {
                var dow = start.AddDays(i).DayOfWeek;
                if (dow != DayOfWeek.Sunday && dow != DayOfWeek.Saturday )
                {
                    result++;
                }

            }
            return result;
        }

    }
}
