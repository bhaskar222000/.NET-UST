using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyFormat
{
    public class Program
    {
        static void Main(string[] args)
        {
            double value = Convert.ToDouble(Console.ReadLine());

            string ch = value.ToString("C", new CultureInfo("zh-CN")); 
            string us = value.ToString("C", new CultureInfo("en-US"));
            string In = value.ToString("C", new CultureInfo("en-IN"));
            string fr = value.ToString("C", new CultureInfo("fr-FR"));
             
            Console.WriteLine("China "+ch);
            Console.WriteLine("US "+us);
            Console.WriteLine("India "+In);
            Console.WriteLine("French "+fr);

        }
    }
}
