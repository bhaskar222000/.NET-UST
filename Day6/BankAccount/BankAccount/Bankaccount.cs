using System;

namespace BankAccount
{
    public class Bankaccount
    {
        public int Id;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private decimal _balance;
        public decimal Balance
        {
            get 
            {                        
                return _balance;
            }
        }

        public void Newaccount(int id, string name, decimal balance)
        {
            Id = id;
            _name = name;
            _balance = balance;
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
            _balance += a;
            Console.WriteLine("Balance Amount after deposit is  "+Balance);
        }

        public void withdraw(decimal a)
        {
            _balance -= a;
            Console.WriteLine($"Balance Amount  after withdrawling {a} is "+Balance);
        }
    }
}
    
    
   
