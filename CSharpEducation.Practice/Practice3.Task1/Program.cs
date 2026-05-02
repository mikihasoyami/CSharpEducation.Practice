using System.Runtime.CompilerServices;

namespace Practice3.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student StudentInfo = new Student();
            Console.WriteLine($"Имя студента: {StudentInfo.StudentName}" + "\r\n" +
                $"Возраст студента: {StudentInfo.StudentAge}");
        }
    }
}
