using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Bankaccount a = null;


            do
            {
                Console.WriteLine("   Banking Menu  ");
                Console.WriteLine("1. Open new account");
                Console.WriteLine("2. Display Account Info ");
                Console.WriteLine("3. Deposit Amount ");
                Console.WriteLine("4. Withdraw Amount");
                Console.WriteLine("5. Check Balance");
                Console.WriteLine("0. Exit ");
                Console.WriteLine("Enter choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name");
                        String Name = Console.ReadLine();
                        Console.WriteLine("Enter Account Id");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter opening balace");
                        decimal Balance = decimal.Parse(Console.ReadLine());
                        a = new Bankaccount();
                        a.Newaccount(Id, Name, Balance);

                        break;
                    case 2:
                        if (a != null)
                        {
                            a.Displayinfo();
                        }
                        else
                            Console.WriteLine("  Open Bank Account  ");

                        break;
                    case 3:
                        if (a != null)
                            a.Deposit(2000);
                        else
                            Console.WriteLine("  Open Bank account  ");
                        break;
                    case 4:
                        if (a != null)
                            a.withdraw(1000);
                        else
                            Console.WriteLine("  Open bank account  ");
                        break;
                    case 5:
                        
                        {

                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("***Enter correct choice***");
                        break;
                }
            }
            while (choice != 0);
            {
                Console.WriteLine("###Thank You Banking with us###");
            }
        }
    }
}