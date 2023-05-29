using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratctEx
{
    class program { 
        public static void Main(string[] args)

        {

            Book new_novel = new MyBook();

            Console.Write("Enter the title: ");

            string title = Console.ReadLine();

            new_novel.SetTitle(title);

            Console.WriteLine("The title is: " + new_novel.GetTitle());

        }

    }
}
