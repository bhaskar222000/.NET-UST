using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            int K = 33; 
            int i=int.Parse(Console.ReadLine());
            try
            {
                K = K / i;
                Console.WriteLine("hello");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("any exception occur or not finally block will print");
            }
        }
    }
}
