namespace Practice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a. строка и символ указываются программно
            char SymbolText = '$';
            string CheckText = "sdfngvaierpgf%?($$$asdfgnad";
            int I = 0;

            foreach (char Symbol in CheckText)
            {
                if (Symbol == SymbolText) 
                    I++;
            }

            double Percent = I * 100.0 / CheckText.Length;
            Console.WriteLine($"Процент вхождения символа '{SymbolText}': {Percent:F2}%");

            // b. строка и символ указываются пользователем в консоли
            Console.WriteLine("Укажите символ, который будем искать");
            string SymbolT = Console.ReadLine();
            char SymbolC;
            Console.WriteLine("Напиши строку, в которой будет искать процент вхождения ранее указанного символа:");
            string CheckTextT = Console.ReadLine();

            // Надо обработать, т.к. пользователь может ввести несколько символов
            while (true)
            {
                if (SymbolT.Length == 1)
                {
                    SymbolC = SymbolT[0];
                    break;
                }
                else
                {
                    Console.WriteLine("Вы указали больше 1 символа, укажите 1 символ:");
                    SymbolT = Console.ReadLine();
                }
            }

            I = 0;
            foreach (char Symbol in CheckTextT)
            {
                if (Symbol == SymbolC)
                    I++;
            }

            Percent = I * 100.0 / CheckTextT.Length;
            Console.WriteLine($"Процент вхождения символа '{SymbolC}': {Percent:F2}%");

            // c. строка и символ указываются через аргументы командной строки
            if (args.Length < 2)
                Console.WriteLine("Использование: <символ> <строка>");

            string SymbolArgs = args[0];
            string StringArgs = args[1];
 
            I = 0;
            foreach (char Symbol in StringArgs)
            {
                if (Symbol == SymbolArgs[0])
                    I++;
            }

            Percent = I * 100.0 / CheckTextT.Length;

            Console.WriteLine($"Процент вхождения символа '{SymbolArgs[0]}': {Percent:F2}%");

        }
    }
}
