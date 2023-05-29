using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerof2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number to check");
                int num = Convert.ToInt32(Console.ReadLine());
                Solution.innerprivate ip = new Solution.innerprivate();
                ip.powerof2(num);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

