using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPricer_csharp
{
    public class FakeRandomGenerator : IRandomGenerator
    {
        public static int bnCall = 0;

        public int GetRandom(int maxValue)
        {
            bnCall++;
            return 1;
        }
    }
}
