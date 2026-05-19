using System;
using System.Collections.Generic;
using System.Text;

namespace Practice4.Task3
{
    public class Dog : Animal
    {
        public Dog(string Name, int Age) : base(Name, Age)
        {
            Console.WriteLine($"Создание новой собаки: имя: {Name}, возраст: {Age}");
        }

        public override string MakeSound()
        {
            return "Woof!";
        }
    }
}
