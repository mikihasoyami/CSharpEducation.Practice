namespace Practice2.Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayValue = {1, -2, 3, -4, 5, -6, 7, -8, 9};
            Console.WriteLine($"Текущий массив чисел: {string.Join(", ", ArrayValue)}");
            GetPositiveArray(ArrayValue, out int[] ArrayNumber);
            Console.WriteLine($"Новый массив чисел: {string.Join(", ", ArrayNumber)}");
        }

        static void GetPositiveArray(int[] ArrayValue, out int[] ArrayNumber)
        {
            int Index = 0;
            int CountValue = 0;

            // Чтобы задать нужный размер нового массива, посчитаем
            foreach (int Value in ArrayValue)
                if (Value > 0) CountValue++;

            ArrayNumber = new int[CountValue];

            for (int I = 0; I < ArrayValue.Length; I++)
            { 
                if (ArrayValue[I] > 0)
                {
                    ArrayNumber[Index] = ArrayValue[I];
                    Index++;
                }
            } 
        }
    }
}
