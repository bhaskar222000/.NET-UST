using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoverianceEX
{
    public class Program
    {
        static void Main(string[] args)
        {
            string state = Console.ReadLine();
            Region region;
            if (state == "WestBengal")
            {
                region = new WestBengal();

            }
            else if (state == "Karnataka")
            {
                region = new Karnataka();
            }
            else if (state == "AndhraPradesh")
            {

                region = new AndhraPradesh();
           }
           else
            {
               region = new Region();
           }
            Flower nationalFlower = region.YourNationalFlower();
            Console.WriteLine(nationalFlower.WhatsYourName());
        }
    }
}
    
