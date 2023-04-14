using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheriAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone ep = new ElectronicPhone("");
            ep.Run();
           
        }
    }
    class Telephone
    {
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        protected string _phonetype;
        public void Ring()
        {
            Console.WriteLine($"Ringing the {_phonetype}");
        }
        public Telephone()
        {

        }
        public Telephone(string phonetype)
        {
            _phonetype = phonetype;
        }
    }
    class ElectronicPhone : Telephone
    {
         string p = "Digital";

        public ElectronicPhone(string phonetype):base(phonetype)
        {
            _phonetype = p;
        }
        public void Run()
        {
            base.Ring();
        }
    }
}
        
       
