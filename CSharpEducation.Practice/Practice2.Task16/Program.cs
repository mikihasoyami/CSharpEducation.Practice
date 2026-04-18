namespace Practice2.Task16
{
    internal class Program
    {
        static void SetNumber(ref int Number)
        {
            Number = -Number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int Number = int.Parse(Console.ReadLine());
            SetNumber(ref Number);
            Console.WriteLine($"Преобразованное число: {Number}");
        }
    }
}
