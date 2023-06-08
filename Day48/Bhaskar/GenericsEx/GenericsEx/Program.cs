using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            string[] arr2 = { "Hello", "World" };
            PrintArray(arr);
            PrintArray(arr2);
        }
        static void PrintArray<T>(T[] array)
        {
            foreach (T e in array)
            {
                Console.WriteLine(e);
            }
       }
    }
}
