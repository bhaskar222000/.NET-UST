using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrac
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i; int n;
            int[] arr = new int[1000];
            Console.WriteLine("Enter array elements:");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Element {0} is:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
           }
            Console.Write("\nElements of array in reverse order are: ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arr[i]);
            } 
            Array.Sort(arr);
            Console.WriteLine(arr);
        }
    }
}
