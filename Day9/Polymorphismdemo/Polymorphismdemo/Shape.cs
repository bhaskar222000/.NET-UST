using System;
using System.Security.Cryptography.X509Certificates;

namespace Polymorphismdemo
{
    class Shape
    {
        public virtual void drawshape()
        {

            Console.WriteLine("draw any shape");
        }
    }

    class circle : Shape
    {
        public override void drawshape()
        {
            Console.WriteLine("cirlce");
        }
    }
    class rectangle : Shape
    {
        public override void drawshape()
        {
            Console.WriteLine("rectangle");
        }
    }
}