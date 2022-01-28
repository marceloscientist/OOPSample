using System.IO;

namespace OOPSample.Models
{
    public class Checking : Account
    {
        private double limit { get; set; }
        public override void toCredit(double value)
        {
            base.balance -= value;
            limit = -100.00;
        }

        public double Limit
        {
            get
            {
                return limit;
            }
            set
            {
                if (balance - value > limit)
                {
                    balance -= value;
                }
                else
                {
                    return;
                }
            }
        }
    }
}