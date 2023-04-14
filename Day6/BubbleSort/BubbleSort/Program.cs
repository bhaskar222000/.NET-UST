using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 5, 30, 25, 40, 20 };
            foreach(int i in a)
            {
                Console.Write(i+"\t");

            }
            int length = a.Length;
            int temp = 0;
            Console.WriteLine();
            Console.WriteLine("\nsorted Array is");
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[i] = temp;
                    }
                }
                
                Console.Write(a[i]+"\t");
            }
        }
    }
}
  