namespace Practice4.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog TDog = new Dog("Петрушка", 3);
            Cat TCat = new Cat("Тыгыдык", 1);
            Console.WriteLine($"Собака говорит: {TDog.MakeSound()}");
            Console.WriteLine($"Кошка говорит: {TCat.MakeSound()}");
        }
    }
}
