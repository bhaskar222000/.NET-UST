using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_1
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value");
            int val = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int j = i + 1;
                sum = arr[i];
                while (j < n)
                {
                    sum += arr[j];
                    if (sum == val)
                    {
                        i += 1;
                        j += 1;
                        Console.WriteLine("Elements need to add from "+i + " to  " + j);
                        n = 0;
                    }
                    j++;
                }
            }

        }

    }
}