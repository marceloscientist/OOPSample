using System;
using System.Linq.Expressions;

namespace OOPSample.Models
{
    public class Person
    {
        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        protected string Name { get; set;}

        protected int Age { get; set; }

        public virtual string ToString()
        {
            return $"{Name} tem {Age}";
        }

    }
    
}