using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramsEx
{
    public class Program
    {
       static void Main(string[] args)
            {
               string a = Console.ReadLine();
                string b = Console.ReadLine();
                if (IsAnagram(a, b))
                {
                    Console.WriteLine("Anagrams");
                }
                else
                {
                    Console.WriteLine("Not Anagrams");
                }
            }
        }
   }
