using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice2.Task9
{
    internal class Program
    {
        static int[] CreateArray(int Size)
        {
            int[] Array = new int[Size];
            Random Rand = new Random();
            for (int I = 0; I < Size; I++)
            {
                // Рандом от 0 до 100
                Array[I] = Rand.Next(0, 100);
            }
            return Array;
        }

        static void PrintArray(int[] Array)
        {
            // Через метод Join чтобы всё было в 1 строке и не писать цикл соединения
            Console.WriteLine("Массив: " + string.Join(", ", Array));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int Size = int.Parse(Console.ReadLine());

            int[] myArray = CreateArray(Size);
            PrintArray(myArray);
        }
    }
}
