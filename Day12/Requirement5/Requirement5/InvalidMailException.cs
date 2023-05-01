using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    class InvalidMailException : Exception
    {
        private string email;
        public InvalidMailException() { }
        public InvalidMailException(string email)
        {
            this.email = email;
        }
        public void inform()
        {
            Console.WriteLine("email is invalid");
        }
    }
}

