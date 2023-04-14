using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int amt = 0, q;
            Console.WriteLine("Enter an amount");
           amt = int.Parse(Console.ReadLine());
            q = amt / 2000;
            amt = amt % 2000;
            Console.WriteLine("{0}\t{1}", q, amt);
            Console.WriteLine("{0} * Rs.2000", q);
            q = amt / 500;
           amt = amt % 500;
            Console.WriteLine("{0}\t{1}", q, amt);
            q = amt / 200;
           amt = amt % 200;
            Console.WriteLine("{0}\t{1}", q, amt);
            q = amt / 100;
            amt = amt % 100;
            Console.WriteLine("{0}\t{1}", q, amt);
            q = amt / 50;
            amt = amt % 50;    
            Console.WriteLine("{0}\t{1}", q, amt);
            q = amt / 20;
            amt = amt % 20;
            Console.WriteLine("{0}\t{1}", q, amt);
            q = amt / 10;
            amt = amt % 10;
            Console.WriteLine("{0}\t{1}", q, amt);
            q = amt / 5;
            amt = amt % 5;
            Console.WriteLine("{0}\t{1}", q, amt);
            q = amt / 1;
            amt = amt % 1;
            Console.WriteLine("{0}\t{1}", q, amt);

        }
    }
}
