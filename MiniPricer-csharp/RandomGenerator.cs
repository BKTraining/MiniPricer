using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPricer_csharp
{
    public class RandomGenerator : IRandomGenerator
    {
        public int GetRandom(int maxValue)
        {
            Random Random = new Random();
            int value = Random.Next(-maxValue, maxValue);
            return value;
        }
    }
}
