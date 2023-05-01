using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PartialDemo
{
    internal partial class Emp    //same class name because we use partial
    {
        public void Display()
        {
            Console.WriteLine(EmpId);
            Console.WriteLine(Name);
        }
    }
}
