using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    public class hello
    {
        int[] arr = new int[] { 1, 3, 2, 3, 4, 31, 6, 4, 34 };
        public int this[int index]
        {
            get { return arr[index];}
            set { arr[index] = value; }
        }
    }
}
