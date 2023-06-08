using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratioprob
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int poscount = 0;
            int negcount = 0;
            int zeroCount = 0;
            foreach (int num in arr)
            {
                if (num > 0)
                    poscount++;
                else if (num < 0)
                    negcount++;
                else
                    zeroCount++;
            }
            double positiveRatio = (double)poscount / n;
            double negativeRatio = (double)negcount / n;
            double zeroRatio = (double)zeroCount / n;
            Console.WriteLine(positiveRatio.ToString("F6"));
            Console.WriteLine(negativeRatio.ToString("F6"));
            Console.WriteLine(zeroRatio.ToString("F6"));

        }

    }

}
