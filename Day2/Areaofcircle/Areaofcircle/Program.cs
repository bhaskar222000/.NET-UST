using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Areaofcircle
{
    internal class Program // by default internal is there
    {
        static void Main(string[] args)
        {
            double r = 0.0; double a;
            Console.WriteLine("enter radius: ");
            r = double.Parse(Console.ReadLine());
            a = Math.PI * r * r;
            Console.WriteLine(a);           
        }
    }
}
