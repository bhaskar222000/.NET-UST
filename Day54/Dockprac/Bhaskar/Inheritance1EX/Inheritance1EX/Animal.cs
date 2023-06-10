using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1EX
{
    class Animal
    {
        public void Walk()
        {
            Console.WriteLine("I am walking");
        }
    }
    class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }
        public void Sing()
        {
            Console.WriteLine("I am singing");
        }
    }
}
