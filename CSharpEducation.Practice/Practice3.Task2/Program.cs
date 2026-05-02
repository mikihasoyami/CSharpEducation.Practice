namespace Practice3.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student StudentInfo = new Student();
            Console.WriteLine($"Имя студента: {StudentInfo.StudentName}" + "\r\n" +
                $"Возраст студента: {StudentInfo.StudentAge}" + "\r\n" +
                $"Средний балл: {StudentInfo.AvgBall}");
        }
    }
}
