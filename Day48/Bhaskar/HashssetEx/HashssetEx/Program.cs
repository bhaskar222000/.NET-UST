using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashssetEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> unipairs = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] pair = Console.ReadLine().Split();
                string s1 = pair[0];
                string s2 = pair[1];
                string pairs = $"{s1} {s2}";
                unipairs.Add(pairs);
                Console.WriteLine(unipairs.Count);
            }
        }
    }
}
