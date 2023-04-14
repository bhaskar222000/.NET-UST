//Absolute differnce b/w two numbers. If n >51 return triple absolute diff.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolutediff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n; 
            Console.WriteLine("Enter n value");
            n = int.Parse(Console.ReadLine());
            int a = Absolutediff(n);
            Console.WriteLine(a);
        }
        static int Absolutediff(int n)
        {
            int b = 51;
            if(n > b)
            {
                return ((n - b) * 3);
            }
            else 
            { 
                return (-(n - b)); 
            }
        }
    }
}
