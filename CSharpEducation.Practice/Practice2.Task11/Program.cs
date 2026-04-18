namespace Practice2.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ArrayCount = int.Parse(args[0]);
            int ArrayValue = int.Parse(args[1]);
            int[] Array = new int[ArrayCount];
            for (int I = 0; I < ArrayCount; I++)
            {
                // Рандом от 0 до 100
                Array[I] = ArrayValue;
            }

            if (ArrayCount > 0)
                Console.WriteLine(string.Join(", ", Array));
        }
    }
}
