using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample
{
    internal class Program
    {
        static void Main(string[] args)
        
       {
            Console.WriteLine(DateTime.Now);//gives exact time
            Console.WriteLine(DateTime.UtcNow);
            DateTime dt = new DateTime(2023,04,11,2,23,32); //yyyy,mm,dd,hr,mn,ms format
            Console.WriteLine(dt); //default time
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Second);
            Console.WriteLine(dt.Millisecond);
            int NumberOfDays = DateTime.DaysInMonth(2023, 4);
            Console.WriteLine(NumberOfDays);
            Console.WriteLine("Comapare of two DATETIMEs");
            DateTime dt1 = new DateTime(2000, 3, 22);
            DateTime dt2 = new DateTime(2022, 3, 22);
            int res = DateTime.Compare(dt1, dt2);
            if (res < 0)
                Console.WriteLine("Date of First is earlier");
            else if (res == 0)
                Console.WriteLine("Both dates are same");
            else
                Console.WriteLine("Date of First is later");
           

        }
    }
}
