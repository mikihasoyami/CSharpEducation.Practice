using System.Runtime.CompilerServices;

namespace Practice3.Task14
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }
    }
}
