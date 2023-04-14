//program to check eligible to vote or not
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the age ");
            int i = int.Parse(Console.ReadLine());

            if (i > 18)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
                Console.WriteLine("Not eligible to vote");
        }
    }
}
