using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice2.Task14
{
    internal class Program
    {
        static int[] GetArray(int ArrayCount)
        {
            return new int[ArrayCount];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int ArrayCount = int.Parse(Console.ReadLine());
            int[] Array = GetArray(ArrayCount);

            Random rand = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(0, 100);
            }

            Console.WriteLine("Массив: " + string.Join(", ", Array));
        }
    }
}
