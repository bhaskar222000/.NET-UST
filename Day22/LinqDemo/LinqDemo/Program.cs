using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "daffodil", "lilly" };
            var fQuery =
                from flower in flowers
                where (flower.StartsWith("d"))
                select flower;
            foreach(string f in fQuery)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine();
            var lquery = from flower in flowers
                         let len=flower.Length
                         where len>5 && len<7
                         select flower;
            foreach(string f in lquery)
            {
                Console.WriteLine(f);
            }
        
        }
    }
}
