namespace Practice2.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число для сравнения:");
            int.TryParse(Console.ReadLine(), out int FirstValue);
            Console.WriteLine("Введите второе целое число для сравнения:");
            int.TryParse(Console.ReadLine(), out int SecondValue);

            if (FirstValue == SecondValue)
                Console.WriteLine($"Значения {FirstValue} и {SecondValue} равны");
            else
            if (FirstValue > SecondValue)
                Console.WriteLine($"Число {FirstValue} больше числа {SecondValue}");
            else
            if (FirstValue < SecondValue)
                Console.WriteLine($"Число {FirstValue} меньше числа {SecondValue}");
        }
    }
}
