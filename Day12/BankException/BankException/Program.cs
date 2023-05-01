using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankException
{
     class Program
    {
        static void Main(string[] args)
        {
            customer c = new customer("Rahul", 2453, 500);

            try

            {

                c.withdraw(480);

            }

            catch (bankexception e)

            {

                Console.WriteLine("Transaction Failed ");

                e.inform();

            }

        }

    }
}
    
