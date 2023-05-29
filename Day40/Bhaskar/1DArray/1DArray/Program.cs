using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array: ");
            

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine()); 
                arr[i] = num;
            }
            Console.WriteLine();
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
