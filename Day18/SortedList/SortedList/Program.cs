using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List_Coll
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedList s= new SortedList();
            s.Add("TS", "hyd");
            s.Add("TN", "chennai");    
            s.Add("Kerala", "triv");
            Console.WriteLine("The keys are ");
           
            foreach (var item in s.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("The values are ");
            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }
            //This is other way to doing
            //IDictionaryEnumerator e= s.GetEnumerator(); 
            //while (e.MoveNext())
            //{
            //    Console.WriteLine(e.Key+ "\t" +e.Value);
            //}
           
            Console.WriteLine("Value at 3rd Index 3: " + s.GetByIndex(3));
            Console.WriteLine("Key at 3rd Index: "+ s.GetKey(3));
            Console.WriteLine("The Index of key Bihar" + s.IndexOfKey("Bihar"));
            Console.WriteLine("The Index of value Jaipur" + s.IndexOfValue("Jaipur"));

        }
    }
}
