using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    public class Program
    {
        public static int Sum(int[] a)
        {
            int total = 0;
            for (int i = 0; i < a.Length; i++)
                total += a[i];
            return total;
        }

        public static void Main()
        {
            int[] a = { 20, 10, 5, 2 };
            Console.WriteLine( Sum(a));
        }
    }
}
 
