using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaConstructor
{
    internal class Emp
    {
        public int eid;
        public string ename; 
        public Emp()
        {
        }  
        public Emp(string name,int id) {
            eid = id;
            ename = name;
        }
    }
}
