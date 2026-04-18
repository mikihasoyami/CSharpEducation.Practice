namespace Practice2.Task25
{
    internal class Program
    {
        enum DayWeek
        {
            Понедельник = 1,
            Вторник = 2,
            Среда = 3,
            Четверг = 4,
            Пятница = 5,
            Суббота = 6,
            Воскресенье = 7
        }

        static void Main(string[] args)
        {
            bool Success = false;

            do
            {
                Console.WriteLine("Введите от 1 до 7 для определения дня недели:");
                int DayCheck;
                int.TryParse(Console.ReadLine(), out DayCheck); ;

                if (DayCheck <= 0 || DayCheck > 7)
                {
                    Console.WriteLine("Введено некорректное значение, введите заново от 1 до 7");
                }
                else
                {
                    Console.WriteLine($"День недели: {(DayWeek)DayCheck}");
                    Success = true;
                }

            } while (!Success);
        }
    }
}
