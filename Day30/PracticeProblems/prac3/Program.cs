using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac3
{
    internal class Program
    {
        //public static int SumDigits(int n)
        //{
        //    string num = Convert.ToString(n);
        //    int sum = 0;
        //    for (int i = 0; i < num.Length; i++)
        //        sum += Convert.ToInt32(num.Substring(i, 1));
        //    return sum;
        //}

        public static void Main()
        {
            bool launchReady = false;
            int fuelLevel = 17000;
            bool crewStatus = true;
            string computerStatus = "green";

            if (fuelLevel >= 20000)
            {
                Console.WriteLine("Fuel level cleared.");
                launchReady = true;
            }
            else
            {
                Console.WriteLine("WARNING: Insufficient fuel!");
                launchReady = false;
            }

            if (crewStatus && computerStatus == "green")
            {
                Console.WriteLine("Crew & computer cleared.");
                launchReady = true;
            }
            else
            {
                Console.WriteLine("WARNING: Crew or computer not ready!");
                launchReady = false;
            }

            if (launchReady==true)
            {
                Console.WriteLine("10, 9, 8, 7, 6, 5, 4, 3, 2, 1...");
                Console.WriteLine("Liftoff!");
            }
            else
            {
                Console.WriteLine("Launch scrubbed.");
            }
        }
    }
}
