using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPricer_csharp
{
    public class WorkingDayTest
    {
        [Test]
        public void Should_return_one_day_when_day_is_15Nov()
        {
            WorkingDay WorkingDay = new WorkingDay();
            int nbDay = WorkingDay.GetWorkingDay(new DateTime(2016, 11, 14), new DateTime(2016, 11, 14));
            Assert.AreEqual(1, nbDay);
        }
    }
}
