using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Emp> list = new List<Emp>();
            list.Add(new Emp("ram","hyd"));
            list.Add(new Emp("sam","trv"));
            list.Add(new Emp("hari","hyd"));
            list.Add(new Emp("sai","up"));
            list.Add(new Emp("aki","tn"));
            list.Add(new Emp("jam","kn"));

            var equery = from Emp emp in list
                         orderby emp.City
                         group emp by emp.City;

            foreach(var e in equery)
            {
                Console.WriteLine("Emp with "+e.Key+" city");
                foreach(var m in e)
                {
                    Console.WriteLine(" " + m.Name);
                }
            }
           

        }
    }
}
