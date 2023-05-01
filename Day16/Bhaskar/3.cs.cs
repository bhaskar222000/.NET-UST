using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortnum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter array size");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            SortNumber(A);
            
        }
        static void SortNumber(int[] A)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    count1++;
                if (A[i] == 1)
                    count2++;
            }
            for (int i = 0; i < count1; i++)
            { 
                A[i] = 0;
            }
            for (int i = count1; i < (count1 + count2); i++)
            {
                A[i] = 1;
            }
            for (int i = (count1 + count2); i < A.Length; i++)
            {
                A[i] = 2;
            }
            Console.WriteLine("Array after sorting: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
   
