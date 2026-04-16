namespace Practice2.Task13
{
    internal class Program
    {
        static int[,] CreateArray(int Rows, int Columns)
        {
            int[,] Array = new int[Rows, Columns];
            Random Rand = new Random();

            for (int I = 0; I < Rows; I++)
            {
                for (int J = 0; J < Columns; J++)
                {
                    Array[I, J] = Rand.Next(0, 100);
                }
            }
            return Array;
        }

        static void PrintArray(int[,] FullArray)
        {
            int Rows = FullArray.GetLength(0);
            int Columns = FullArray.GetLength(1);

            for (int I = 0; I < Rows; I++)
            {
                for (int J = 0; J < Columns; J++)
                {
                    // По 4 знака в строку
                    Console.Write($"{FullArray[I, J]} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк:");
            int Rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов:");
            int Columns = int.Parse(Console.ReadLine());

            int[,] FullArray = CreateArray(Rows, Columns);
            Console.WriteLine("Созданный массив:");
            PrintArray(FullArray);
        }
    }
}
