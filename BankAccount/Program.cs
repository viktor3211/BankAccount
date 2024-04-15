using System.Diagnostics.Metrics;
using System.Reflection;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();
            bankAccount1.Deposit(100);
            bankAccount2.Deposit(50);
            Console.WriteLine("Account1: " + bankAccount1.GetBalance());
            Console.WriteLine("Account2: " + bankAccount2.GetBalance());
            bankAccount1.Withdraw(20);
            bankAccount2.Deposit(70);
            Console.WriteLine("Account1: " + bankAccount1.GetBalance());
            Console.WriteLine("Account2: " + bankAccount2.GetBalance());
            bankAccount1.Withdraw(9999);
            Console.WriteLine("Account1: " + bankAccount1.GetBalance());
        }


    }
}