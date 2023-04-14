//Constructors example
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ename; int eid;
            Console.WriteLine("enter name ");
            ename=Console.ReadLine();
            Console.WriteLine("enter id ");
            eid = int.Parse( Console.ReadLine());
            Emp e = new Emp(ename, eid);
            Console.WriteLine(e.ename);
            Console.WriteLine(e.eid);

        }
    }
}
