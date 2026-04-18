namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            int RandomValueCount = Rand.Next(1, 100);
            Console.WriteLine($"Размер основного массива: {RandomValueCount}");
            int[] Array = new int [RandomValueCount];
            int Index = 0;

            // Заполняем массив рандомными числами
            foreach (int Value in Array)
            {
                Array[Index] = Rand.Next(1,100);
                Index++;
            }

            Console.WriteLine($"Массив данных: {string.Join(", ", Array)}");
            int MaxValue = Array.Max();
            int MinValue = Array.Min();

            // Выводим разницу
            Console.WriteLine($"Максимальное число в массиве: {MaxValue}");
            Console.WriteLine($"Минимальное число в массиве: {MinValue}");
            Console.WriteLine($"Разница: {MaxValue - MinValue}");
        }
    }
}
