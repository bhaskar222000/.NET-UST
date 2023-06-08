using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparatorEx
{
        class Checker : IComparer<Player>
        {
            public int Compare(Player a, Player b)
            {
                if (a.Score != b.Score)
                {
                    return b.Score.CompareTo(a.Score);
                }
                else
                {               
                    return a.Name.CompareTo(b.Name);
                }
            }
        }
}
