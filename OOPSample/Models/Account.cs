namespace OOPSample.Models
{
    public abstract class Conta
    {
        protected double balance;
        public abstract void toCredit();

        public void showBalance()
        {
            System.Console.WriteLine($"Seu saldo é {balance}");
        }
    }
}