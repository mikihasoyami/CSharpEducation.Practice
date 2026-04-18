namespace Practice2.Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год для последующего его определения");
            int Year = int.Parse(Console.ReadLine());

            if (Year % 400 == 0)
                Console.WriteLine($"{Year} — високосный год (кратен 400)");
            else if (Year % 100 == 0)
                Console.WriteLine($"{Year} — невисокосный год (кратен 100)");
            else if (Year % 4 == 0)
                Console.WriteLine($"{Year} — високосный год (кратен 4)");
            else
                Console.WriteLine($"{Year} — невисокосный год");
        }
    }
}
