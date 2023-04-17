using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentMail
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter Mail1 details: ");
           
            string[] s = Console.ReadLine().Split(',');
            Mail m1 = new Mail(int.Parse(s[0]), s[1], s[2], s[3], s[4],
                Convert.ToDateTime(s[5]), Convert.ToDouble(s[6]));
            Console.WriteLine("Enter Mail2 details: ");

            string[] s2 = Console.ReadLine().Split(',');
            Mail m2 = new Mail(int.Parse(s2[0]), s2[1], s2[2], s2[3], s2[4],
                Convert.ToDateTime(s2[5]), Convert.ToDouble(s2[6]));
            
            Console.WriteLine("Mail 1 :\n" + m1);
            Console.WriteLine("Mail 2 : \n" + m2);

            if (s[1] == s2[1] && s[2] == s2[2] && s[3] == s2[3])
            {
                Console.WriteLine("Mail 1 is same as Mail2");
            }
            else
            {
                Console.WriteLine("Mail 1 and Mail 2 is different");
            }
        }
    }
}
