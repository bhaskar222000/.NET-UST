using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure f = new Circle();
            Figure s = new Square();
            f.Dimension = 10;
            s.Dimension = 10;
            Console.WriteLine(f.Area()+"\t"+s.Area());
            Console.WriteLine(f.Perimeter()+"\t"+s.Perimeter());

        }
    }

}
