using OOPSample.Interfaces;

namespace OOPSample.Models
{
    public class Calculator : ICalculator
    {
        public int Summing(int num, int num2) => num + num2;
    }
}