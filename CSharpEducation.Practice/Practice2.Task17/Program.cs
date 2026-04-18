namespace Practice2.Task17
{
    internal class Program
    {
        static void ChangeNumber(ref int Number1, ref int Number2)
        {
            int TempN = Number1;
            Number1 = Number2;
            Number2 = TempN;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите первое число");
            int Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int Number2 = int.Parse(Console.ReadLine());
            ChangeNumber(ref Number1, ref Number2);
            Console.WriteLine($"Пример изменений: {Number1} и {Number2}");
        }
    }
}
