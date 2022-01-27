using System;
using OOPSample.Models;

namespace OOPSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person marcelo = new Teacher("Marcelo", 38);
            Console.WriteLine(marcelo.ToString());
        }
    }
}
