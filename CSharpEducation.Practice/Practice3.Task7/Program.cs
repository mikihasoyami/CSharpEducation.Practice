namespace Practice3.Task7
{
    internal class Program
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static int GetDayInMonth(int Year, Months Month)
        {
            switch (Month)
            { 
                case Months.January:
                case Months.March:
                case Months.May:
                case Months.July:
                case Months.November:
                case Months.December:
                    return 31;
                case Months.April:
                case Months.June:
                case Months.September:
                case Months.October:
                    return 30;
                case Months.February:
                    if (DateTime.IsLeapYear(Year))
                        return 29;
                    else
                        return 28;
                default: return 0;
            }
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Дней в феврале: {GetDayInMonth(2024, Months.February)}");
            Console.WriteLine($"Дней в сентябре: {GetDayInMonth(2026, Months.September)}");
        }
    }
}
