using System.Numerics;

namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            int FirstArrayCount = Rand.Next(1, 100);
            int SecondArrayCount = Rand.Next(1, 100);
            int[,] Array = new int[FirstArrayCount, SecondArrayCount];
            int FirstIndex = 0;
            int SecondIndex = 0;
            Console.WriteLine($"Размер первого кластера массива: {FirstArrayCount}");
            Console.WriteLine($"Размер выторого кластера массива: {SecondArrayCount}");

            // Заполняем массив значениями
            for (int I = 0; I < FirstArrayCount; I++)
            {
                for (int J = 0; J < SecondArrayCount; J++)
                {
                    Array[I, J] = Rand.Next(1, 100);
                }
            }

            Console.WriteLine($"Массив данных массива: {string.Join(", ", Array)}");
            // Чтобы выявить мин и макс прогуляемся в цикле
            for (int I = 0;  I < FirstArrayCount; I++)
            {
                // Задаём минимальное и максимальное значение с превышением для сверки
                int MaxValue = 0;
                int MinValue = 100;

                for (int J  = 0; J < SecondArrayCount; J++)
                {
                    if (Array[I, J] < MinValue)
                        MinValue = Array[I, J];

                    if (Array[I, J] > MaxValue)
                        MaxValue = Array[I, J];
                }

                // Выводим разницу
                Console.WriteLine($"Максимальное число в массиве: {MaxValue}");
                Console.WriteLine($"Минимальное число в массиве: {MinValue}");
                Console.WriteLine($"Разница: {MaxValue - MinValue}");
            }    
        }
    }
}
