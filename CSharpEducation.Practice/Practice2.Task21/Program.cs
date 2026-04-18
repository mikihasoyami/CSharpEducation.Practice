namespace Practice2.Task21
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

            do
            {
                Console.WriteLine("Введите число от 1 до 100");
                int ClientValue = int.Parse(Console.ReadLine());
                Console.WriteLine($"Вы ввели число: {ClientValue}");

                if (ClientValue == Value)
                {
                    Console.WriteLine("Вы победили!");
                    Finish = true;
                }
                else
                    Console.WriteLine("Не отгадал, давай ещё раз!");

            } while (!Finish);
        }
    }
}
