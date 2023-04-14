using System;

namespace BankAccount
{
    public class Bankaccount
    {
        public int Id;
        public string Name;
        public decimal Balance;

        public void Newaccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }
        public void Displayinfo()
        {
            Console.WriteLine("   Account info   ");
            Console.WriteLine("Name is " + Name);
            Console.WriteLine("Id is " + Id);
            Console.WriteLine("Balance is " + Balance);
        }
        public void Deposit(decimal a)
        {
            Balance += a;
            Console.WriteLine("Balance Amount after deposit is  "+Balance);
        }

        public void withdraw(decimal a)
        {
            Balance -= a;
            Console.WriteLine($"Balance Amount  after withdrawling {a} is "+Balance);
        }
    }
}
    
    
   
