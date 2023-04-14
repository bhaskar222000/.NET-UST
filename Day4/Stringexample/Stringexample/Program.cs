//simple string example
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Enter string value :");
            s= Console.ReadLine();
            Console.WriteLine(s.ToUpper());
            Console.WriteLine(s.ToLower()); 
        }
    }
}
