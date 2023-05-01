using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDemo
{
    delegate void CountIt();
    class Program
    {
        static void Main(string[] args)
        {
            CountIt count = delegate
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            };
            count();

        }
    }
}
