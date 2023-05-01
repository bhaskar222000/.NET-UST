﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missingnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Enter size of Array:");
            N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < A.Length - 1; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            int size = N;
            int total = size * (size + 1) / 2;
            int res = Sum(A, N);
            int element = total - res;
            Console.WriteLine("Missing element is :" + element);
        }
        static int Sum(int[] A, int N)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i];
            return sum;
        }
    }
}

