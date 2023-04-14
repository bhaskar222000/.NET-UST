using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigure fig = null;
            Console.WriteLine("Enter C for Circle or S for Square ");
            string ch=Console.ReadLine();
            if (ch == "C")
                fig = new Circle();
            else if (ch == "S")
                fig = new Square();
            fig.Dimension = 10;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());
        }
    }

}
