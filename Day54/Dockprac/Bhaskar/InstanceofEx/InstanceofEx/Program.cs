using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceofEx
{
    class Student { }
    class Rockstar { }
    class Hacker { }
    public class Program
    {
        static void Main(string[] args)
        {
            List<object> ls = new List<object>();
            int t = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                if (s.Equals("Student"))
                {
                    ls.Add(new Student());
                }
                else if (s.Equals("Rockstar"))
                {
                    ls.Add(new Rockstar());
                }
                else if (s.Equals("Hacker"))
                {
                    ls.Add(new Hacker());
                }
            }
            int studentCount = 0;
            int rockstarCount = 0;
            int hackerCount = 0;
            foreach (var obj in ls)
            {
                if (obj is Student)
                {
                    studentCount++;
                }
                else if (obj is Rockstar)
                {
                    rockstarCount++;
                }
                else if (obj is Hacker)
                {
                    hackerCount++;
                }
            }
            Console.Write(studentCount+" "+ rockstarCount+" "+ hackerCount);
        }
    }
}
