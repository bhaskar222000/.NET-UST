using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            hello a;
            a=new hello();
            a[3] = 88;
            a[0] = 0;
            Console.WriteLine(a[3]);
            Console.WriteLine(a[0]);
        }
    }
}
