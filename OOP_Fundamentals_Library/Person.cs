using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Fundamentals_Library
{
    public abstract class Person
    {
        private int _age;
        private string _name;

        public string Name
        {
            get { return _name; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("The name cannot be empty.");
                _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 150)
                    throw new ArgumentException("The age should be from 0 to 150");
                _age = value;
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Person: {Name}, {Age} years old"); 
        }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
