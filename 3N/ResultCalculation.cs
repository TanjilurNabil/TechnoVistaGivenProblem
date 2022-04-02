using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _3N
{
    public class ResultCalculation
    {
        
        public static long cycleLength(long n)
        {
            if (n == 1)
            {
                return 1;
            }
            return 1 + cycleLength(n % 2 == 0 ? n / 2 : 3 * n + 1);
        }
        public static long maxCycleLength(long start, long end)
        {
            if (start > end)
            {
                long tempswap = start;
                start = end;
                end = tempswap;
            }

            long min = Math.Min(start, end);
            long max = Math.Max(start, end);
            long maxCycleLength = 0;

            for (long i = min; i <= max; i++)
            {
                long cycleLength = ResultCalculation.cycleLength(i);
                if (cycleLength > maxCycleLength)
                {
                    maxCycleLength = cycleLength;
                }
            }

            return maxCycleLength;
        }
        
    }
}