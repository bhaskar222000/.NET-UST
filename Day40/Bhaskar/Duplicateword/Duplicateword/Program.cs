using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Duplicateword
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the sentence");
                string ip = Console.ReadLine();
                string op = Regex.Replace(ip, @"(?i)\b(\w+)(\s+\1)+\b", "$1");
                Console.WriteLine(op);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
