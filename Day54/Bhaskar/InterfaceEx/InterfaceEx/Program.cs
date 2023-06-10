using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            AdvancedArithmetic myCal = new MyCalculator();
            int sum = myCal.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic");
            Console.WriteLine(sum);
        }
    }
}
