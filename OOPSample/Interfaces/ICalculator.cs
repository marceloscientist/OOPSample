namespace OOPSample.Interfaces
{
    public interface ICalculator
    {
        int Summing(int num, int num2);
        int Subtraction(int num, int num2) => num - num2;
        int Multiplication(int num, int num2) => num * num2;
        int Division(int num, int num2) => num / num2;

    }
}