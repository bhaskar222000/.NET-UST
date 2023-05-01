using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
    class Member
    {
        string firstname;
        string lastname;
        string email;
        public Member() { }
        public Member(string firstname, string lastname, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }
        public void checking(string email)
        {
            if (email.Contains("@") && email.EndsWith(".com"))
            {
                Console.WriteLine("email is valid");
            }
            else
            {
                throw new InvalidMailException(email);
            }
        }
    }
}