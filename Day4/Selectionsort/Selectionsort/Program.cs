using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selectionsort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of values:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            selectsort(arr);
        }
        public static void selectsort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int a = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[a])
                    {
                        a = j;
                    }
                    int temp = arr[a];
                    arr[a] = arr[i];
                    arr[i] = temp;
                }
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
