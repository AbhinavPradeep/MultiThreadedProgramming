using System;
using System.Threading;

namespace MultiThreadedProgramming
{
    class Account
    {
        public Account()
        {
            Balance = 0.00;
        }
        public Double Balance{get; private set;}

        public void Withdraw(double Amount)
        {
            if (Balance >= Amount)
            {
                Thread.Sleep(10000);
                Balance -= Amount;
                System.Console.WriteLine($"Balance = ${Balance}");
            }
            else
            {
                System.Console.WriteLine($"Sorry you only have ${Balance} left");
            }
        }

        public void Deposit(double Amount)
        {
            Balance+= Amount;
            System.Console.WriteLine($"Balance = ${Balance}");
        }
    }
}
