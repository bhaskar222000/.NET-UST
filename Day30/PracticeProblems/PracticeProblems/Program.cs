using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Number {0} =  ", i);
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 4; i >= 0; i--)
            {
                Console.Write("{0} ", n[i]);
            }
        }
    }
}
