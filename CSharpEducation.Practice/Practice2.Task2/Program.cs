namespace Practice2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Преобразование км в метры
            Console.WriteLine("Введите число в километрах:");
            float.TryParse(Console.ReadLine(), out float Km);
            float Meter = Km * 1000;
            Console.WriteLine($"В метрах: {Meter}");

            // Преобразование км в см
            Console.WriteLine("Введите число в километрах:");
            float.TryParse(Console.ReadLine(), out Km);
            float Santim = Km * 100000;
            Console.WriteLine($"В сантиметрах: {Santim}");

            // Преобразование м/с в км/ч
            Console.WriteLine("Введите число в м/с:");
            float.TryParse(Console.ReadLine(), out float MeterInSec);
            double KmInSec = MeterInSec * 3.6;
            Console.WriteLine($"В км/ч: {KmInSec}");

            // Преобразование градусы C в градусы F
            Console.WriteLine("Введите значение градусов в C:");
            float.TryParse(Console.ReadLine(), out float C);
            double F = (C * 9 / 5) + 32;
            Console.WriteLine($"Значение градусов в F: {F}");
        }
    }
}
