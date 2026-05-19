using Practice3.Task14;

namespace Practice3.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Иван", 30);
            Person person2 = new Person("Мария", 25);

            // Вывод информации
            person1.Print();
            person2.Print();
        }
    }
}
