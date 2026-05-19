using System;
using System.Collections.Generic;
using System.Text;

namespace Practice4.Task3
{
    public class Cat : Animal
    {
        public Cat(string Name, int Age) : base(Name, Age)
        {
            Console.WriteLine($"Создание нового кота: имя: {Name}, возраст: {Age}");
        }

        public override string MakeSound()
        {
            return "Meow!";
        }
    }
}
