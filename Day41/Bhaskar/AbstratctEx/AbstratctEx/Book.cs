using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratctEx
{
    abstract class Book
    {
        protected string title;
        public abstract void SetTitle(string s);
        public string GetTitle()
        {
            return title;
        }
    }
    class MyBook : Book
    {
        public override void SetTitle(string s)
        {
            title = s;

        }

    }
}
