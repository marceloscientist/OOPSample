namespace OOPSample.Models
{
    public abstract class Account
    {
        protected double balance;
        public abstract void toCredit(double value);

        public void showBalance()
        {
            System.Console.WriteLine($"Seu saldo é {balance}");
        }
    }
}