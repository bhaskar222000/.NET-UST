﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2EX
{
    public class Program
    {
        static void Main(string[] args)
        {
            Adder a = new Adder();
            Console.WriteLine("My superclass is: Arthimetic");
            Console.WriteLine(a.Add(10, 32) + " " + a.Add(10, 3) + " " + a.Add(10, 10));
        }
    }
}
