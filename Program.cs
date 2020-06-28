using System;
using System.Threading;

namespace MultiThreadedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Savings = new Account();
            Savings.Deposit(100.00);

            Thread[] ArrayOfThreads = new Thread[15];
            for (int i = 0; i < 15; i++)
            {
                Thread thread = new Thread(() =>
                {
                    Savings.Withdraw(90.00);
                });
                ArrayOfThreads[i] = thread;
            }
            for (int i = 0; i < 15; i++)
            {
                ArrayOfThreads[i].Start();
            }
        }
    }
}
