using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{
     class Program
    {
        static void Main(string[] args)
        {
            ArrayList li = new ArrayList();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter details:");
                string input = Console.ReadLine();
                string[] arr = input.Split(',');
                Member member = new Member(arr[0], arr[1], arr[2]);
                try
                {
                    member.checking(arr[2]);
                }
                catch (InvalidMailException e)
                {
                    e.inform();
                }
                li.Add(member);
                member.ToString();
                li.ToString();
            }
        }
    }
}
