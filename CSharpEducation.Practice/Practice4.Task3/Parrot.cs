using System;
using System.Collections.Generic;
using System.Text;

namespace Practice4.Task3
{
    public class Parrot : Animal
    {
        public string Color { get; set; }
        public Parrot(string Name, int Age, string Color) : base(Name, Age)
        {
            Color = Color;
            Console.WriteLine($"Попугай: имя: {Name}, возраст: {Age}, Цвет: {Color}");
        }

        public new string MakeSound(string Words)
        {
             string FullWords = "";

            for (int I = 0; I < 3; I++)
            {
                FullWords = FullWords + "\n" + Words;
            }

            if (FullWords != "")
                return FullWords;
            else
                return Words;
        }
    }
}
