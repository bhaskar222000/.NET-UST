using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEg
{
     class Program
    {
        static void Main(string[] args)
        {
            orange oo = new orange(23,"bhaskar");

        }
    }
        public class fruit
        {
        private int _id;
        private string _name;
        public int Number
        {
            get { return _id; }
            set { _id = value; }

        }
        public string Name
        {
            get { return _name; }   
            set { _name = value; }
        }
        public fruit()
        {

        }
        public fruit(int id, string name)
        {
            _id = id;   
            _name = name;
        }
        }
    public class orange : fruit
    {

        public orange(int id, string name, string origin) : base(id, name)
        {
            _origin = origin;
        }
        public string[] state = { "maharashtra", "himachal pradesh", "telangana" };
        private string _origin;

        public string Origin
        {
            get { return _origin; }
            set
            { if(Origin.Contains())
                _origin = value;
            }
        }
    }

    }
