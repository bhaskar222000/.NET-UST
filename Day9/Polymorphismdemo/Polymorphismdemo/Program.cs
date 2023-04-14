using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape s = new Shape();
            s.drawshape();
            circle c = new circle();
            c.drawshape();
            rectangle r = new rectangle();
            r.drawshape();
            Shape ss = new circle(); //upcasting
            ss.drawshape();
            //Array of refernces of base class referncing 
            //Derived class object(upcasting)

        }
    }

}

