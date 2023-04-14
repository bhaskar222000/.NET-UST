using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiesexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i;
            //for (i = 0; i < 100; i++)
            //{
            //    if(i%2!=0) 
            // if(i%2==0)
            //    Console.WriteLine(i);
            //}

            Console.Write("Enter sentence : ");
            String s = Console.ReadLine();
            int i = 0;
            foreach (char ch in s)
            {
                if ("aeiou".Contains(ch))
                    i++;
                if ("AEIOU".Contains(ch))
                    i++;
            }
            Console.WriteLine(i);
        }
    }
}
