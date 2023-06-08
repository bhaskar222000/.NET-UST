using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateandTImeEX
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int month = int.Parse(input[0]);
            int day = int.Parse(input[1]);
            int year = int.Parse(input[2]);
            DateTime date = new DateTime(year, month, day);
            string dayOfWeek = date.ToString("dddd").ToUpper();
            Console.WriteLine(dayOfWeek);
        }
    } 
}

