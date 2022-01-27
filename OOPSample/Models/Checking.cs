namespace OOPSample.Models
{
    public class Checking : Account
    {
        public override void toCredit(double value)
        {
            base.balance -= value;
        }
    }
}