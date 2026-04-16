using System.Drawing;

namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ArrayCount = int.Parse(args[0]);
            int[] Array = new int[ArrayCount];
            Random Rand = new Random();
            for (int I = 0; I < ArrayCount; I++)
            {
                // Рандом от 0 до 100
                Array[I] = Rand.Next(0, 100);
            }

            if (ArrayCount > 0)
                Console.WriteLine(string.Join(", ", Array));
        }
    }
}
