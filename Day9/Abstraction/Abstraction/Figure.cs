using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Figure
    {
        public int Dimension;
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Circle : Figure
    {
        public override double Area()
        {
            return Math.PI * Dimension * Dimension;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Dimension;
        }
    }
    class Square : Figure
    {
        public override double Area()
        {
            return Dimension * Dimension;
        }
        public override double Perimeter()
        {
            return 4 * Dimension;
        }
    }
}
