namespace OOPSample.Models
{
    public class Teacher : Person 
        
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        private double Wage { get; set; }
        public override string ToString()
        {
            return $"Sou aluno {Name} de idade {Age}";
        }
    }
}