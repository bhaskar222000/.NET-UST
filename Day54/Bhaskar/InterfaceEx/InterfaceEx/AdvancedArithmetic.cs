﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public interface AdvancedArithmetic
    {
       int divisorSum(int n);
    }
    class MyCalculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
   }
}
