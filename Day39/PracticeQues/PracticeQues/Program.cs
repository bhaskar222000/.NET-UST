using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQues
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student type:");
            string studenttype = Console.ReadLine();
            Console.WriteLine("Enter tuition fee:");
            float tuitionfee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter bus fee:");
            float busfee = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter hostel fee:");
            float hostelfee = float.Parse(Console.ReadLine());
            float amount = 0;

            if (studenttype == "msds")
            {
                amount = tuitionfee + busfee;
            }
            else if (studenttype == "msh")
            {
                amount = tuitionfee + hostelfee;
            }
            else if (studenttype == "mgsds")
            {
                amount = 1.5f * tuitionfee + busfee;
            }
            else if (studenttype == "mgsh")
            {
                amount = 1.5f * tuitionfee + hostelfee;
            }
            Console.WriteLine($"The fees to be paid by the student is Rs.{amount:0.00} ");
        }
    }
}
