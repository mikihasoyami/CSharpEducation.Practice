using System;
using System.Collections.Generic;
using System.Text;

namespace Practice4.Task3
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string Name, int Age)
        {
            Name = Name;
            Age = Age;
        }

        public string Eat()
        {
            return "Animal is eating";
        }

        public string Sleep()
        {
            return "Animal is sleeping";
        }

        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }
    }
}
