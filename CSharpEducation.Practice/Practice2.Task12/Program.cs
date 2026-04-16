namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayString = new string[3];
            // Сделаем цикл по введению, но ограничим 3 значениями
            for (int I = 0; I < 3; I++)
            {
                Console.WriteLine($"Введите {I + 1} значение: ");
                ArrayString[I] = Console.ReadLine();
            } 

            if(ArrayString.Length == 3)
            {
                Console.WriteLine($"Словосочетание: {string.Join(", ", ArrayString)}");
            }
        }
    }
}
