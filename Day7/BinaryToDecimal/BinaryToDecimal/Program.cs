using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; int num;
            Console.Write("Enter the Decimal Number : ");
            num = int.Parse(Console.ReadLine());
            int[] n = new int[10];
            for (i = 0; num > 0; i++)
            {
                n[i] = num % 2;
                num = num / 2;
            }
            Console.Write("Binary number: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(n[i]);
            }
        }
    }
}
