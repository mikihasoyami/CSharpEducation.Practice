namespace Practice2.Task24
{
    internal class Program
    {
        enum DayWeek
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Список дней недели:");

            // Пробегаемся в цикле и выводим каждый день недели
            foreach (DayWeek Day in Enum.GetValues(typeof(DayWeek)))
                Console.WriteLine($"День недели: {Day}");
        }
    }
}
