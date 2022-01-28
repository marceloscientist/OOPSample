using System;

namespace OOPSample.Models
{
    public abstract class Account
    {
        public Account()
        {
            this.balance = 0.00;
        }

        public Account(double value)
        {
            this.balance = value;
        }
        protected double balance;
        public abstract void toCredit(double value);

        public void showBalance()
        {
            System.Console.WriteLine($"Seu saldo é {balance}");
        }
    }
}