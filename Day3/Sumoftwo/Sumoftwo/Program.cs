//sum of two numbers adn return triple result if two numbers are equal.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumoftwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; int b;
            Console.WriteLine("enter a value ");
            Console.WriteLine("enter b value ");
            a= int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            int c = twonum(a, b);
            Console.WriteLine(c);
        }
        static int twonum(int a, int b)
        {
            if(a == b)
            {
                return (a + b * 3);
            }
            else
            {
                return a + b;
            }
        }
    }
}
