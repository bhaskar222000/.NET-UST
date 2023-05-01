using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegateDemo
{
     class Program
    {
        public delegate int sumof(int i, int j);
        static void Main(string[] args)
        {
            int res = 0;   
            sumof s = delegate (int x, int y)
            {               
                return x + y;
            };
            res = s(10, 20);
            Console.WriteLine(res);
            
        }
    }
}
