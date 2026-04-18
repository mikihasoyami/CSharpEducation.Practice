namespace Practice2.Task15
{
    internal class Program
    {
        static void GetInvertverArray(int[] MyArray)
        {
            int ArrayCount = MyArray.Length;
            // Проблема в том, что ArrayCount - I - 1 может перезаписаться на середине, поэтому затащим в temp переменную
            // И будем делить на 2.
            for (int I = 0; I < ArrayCount / 2; I++)
            {
                int Temp = MyArray[I];
                MyArray[I] = MyArray[ArrayCount - I - 1];
                MyArray[ArrayCount - I - 1] = Temp;
            }
        }

        static void Main(string[] args)
        {
            int[] MyArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"Исходный массив: {string.Join(", ", MyArray)}");
            GetInvertverArray(MyArray);
            Console.WriteLine("Полученный массив после инвертирования");
            Console.WriteLine("Массив: " + string.Join(", ", MyArray));
        }
    }
}
