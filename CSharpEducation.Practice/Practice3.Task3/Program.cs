using System.Runtime.ExceptionServices;

namespace Practice3.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator Calculate = new Calculator();
            Console.WriteLine("Введите первое число:");
            double FirstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double SecondValue = double.Parse(Console.ReadLine());
            Console.WriteLine($"Плюс: {Calculate.Plus(FirstValue, SecondValue)}");
            Console.WriteLine($"Минус: {Calculate.Minus(FirstValue, SecondValue)}");
            Console.WriteLine($"Умножение: {Calculate.Multi(FirstValue, SecondValue)}");
            Console.WriteLine($"Деление: {Calculate.Div(FirstValue, SecondValue)}");
        }
    }
}
