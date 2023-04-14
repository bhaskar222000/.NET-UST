using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DebugDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no: ");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine("Eneter second no: ");
            int j=int.Parse(Console.ReadLine());
            show(i,j);
            Console.WriteLine("Debugging is done");
        }
        public static void show(int a, int b)
        {
            int t = 100;
            for(int i=a;i<=b;i++) {
                Console.WriteLine("India");
                t = t * 34;
            }
        }
    }
}
