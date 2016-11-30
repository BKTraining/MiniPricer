using System;
using System.Linq;
using System.Threading.Tasks;

namespace MiniPricer_csharp
{
    public class Pricer
    {
        double _precision;
        IWorkingDay _workingDayCalculator = new WorkingDay();
        IRandomGenerator _randomGenerator = new RandomGenerator();

        public double getPrice(DateTime currentDate, DateTime futurDate, double currentPrice, double volatility)
        {
            int duration =  _workingDayCalculator.GetWorkingDay(currentDate, futurDate);
            double price = currentPrice;
            for (int i = 1; i < duration; i++)
            {
                price *= (1 + volatility / 100) * _randomGenerator.GetRandom(1);
            }
            return price;
        }

        public Pricer( double precision)
        {
            _precision = precision;
        }


        public Pricer(double precision, IWorkingDay wd, IRandomGenerator randomGenerator)
        {
            _precision = precision;
            _workingDayCalculator = wd;
            _randomGenerator = randomGenerator;
        }
    }
}