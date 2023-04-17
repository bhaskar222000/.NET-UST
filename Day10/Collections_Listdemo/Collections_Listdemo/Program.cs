using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Listdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generic 
            //string type
            List<string> list = new List<string>();
            list.Add("hi");
            list.Add("hello");
            list.Add("hiiiii");
            list.Add("hellllllllo");
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
            //int type
            List<int> i = new List<int>();
            i.Add(1);
            i.Add(22);
            i.Add(333);
            i.Add(444);
            foreach(int s in i)
            {
                Console.WriteLine(s);
                    
            }
            //sortedList <key,value>
            Console.WriteLine("");
            SortedList<int, string> n = new SortedList<int, string>();
            n.Add(3, "Three");
            n.Add(1, "One");
            n.Add(2, "Two");
            n.Add(4, null);
            n.Add(10, "Ten");
            n.Add(5, "Five");
            foreach(object o in n)
            {
                Console.WriteLine(o);
            }
                

        }
    }
}
