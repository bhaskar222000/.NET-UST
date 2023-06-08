using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdayCandles
{
    class Result
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int maxHeight = 0;
            int count = 0;
            
            foreach (int height in candles)
            {
                if (height > maxHeight)
                {
                    maxHeight = height;
                    count = 1;
                }
                else if (height == maxHeight)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
