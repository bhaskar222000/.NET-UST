using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo2
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[5];
            try
            {
                int i = 10 / a;
                b[10] = 6;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero error");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range");
            }
            finally 
            {
                Console.WriteLine("printing finally");
            }
            Console.WriteLine("program");

        }
    }
}
