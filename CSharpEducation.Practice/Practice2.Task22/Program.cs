namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру угадай число");
            Random Rand = new Random();
            int Value = Rand.Next(1, 100);
            Console.WriteLine($"Число на загадку: {Value}");
            bool Finish = false;
            int LimitForWin = 10;
            int Count = 0;

            do
            {
                if (LimitForWin == Count)
                {
                    Console.WriteLine("Пользователь проиграл");
                    break;
                }

                Console.WriteLine("Введите число от 1 до 100");
                int ClientValue = int.Parse(Console.ReadLine());
                Console.WriteLine($"Вы ввели число: {ClientValue}");

                if (ClientValue == Value)
                {
                    Console.WriteLine("Вы победили!");
                    Finish = true;
                }
                else
                {
                    Console.WriteLine("Не отгадал, давай ещё раз!");
                    if (ClientValue < Value)
                        Console.WriteLine("ПОДСКАЗКА: Число больше того, что вы ввели");
                    else
                        Console.WriteLine("Число меньше того, что вы ввели");
                    Count++;
                }

            } while (!Finish || (LimitForWin > Count));
        }
    }
}
