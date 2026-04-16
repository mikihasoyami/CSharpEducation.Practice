namespace Practice2.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите строку, которую требуется перевести в регистр");
            string TextFiled = Console.ReadLine();
            Console.WriteLine("Выберите 1 для перевода строки в нижний регистр, 2 - в верхний и 3 - для заглавной первой буквы");
            int.TryParse(Console.ReadLine(), out int Register);

            // Проверяем, что ввели корректные значения
            while (true)
            {
                if (Register == 1 || Register == 2 || Register == 3)
                    break;
                else
                {
                    Console.WriteLine("Введено некорректное значение, выберите вновь");
                    int.TryParse(Console.ReadLine(), out Register);
                }
            }

            // Пробились через проверку, дальше по условиям
            if (Register == 1)
                Console.WriteLine($"Ваша строка в нижнем регистре: {TextFiled.ToLower()}");
            else
            if (Register == 2)
                Console.WriteLine($"Ваша строка в нижнем регистре: {TextFiled.ToUpper()}");
            else
            if (Register == 3)
                Console.WriteLine($"Ваша строка в с первой заглавной буквы: {char.ToUpper(TextFiled[0]) + TextFiled.Substring(1)}");
            else
                Console.WriteLine("Как-то умудрились поломать");
        }
    }
}
