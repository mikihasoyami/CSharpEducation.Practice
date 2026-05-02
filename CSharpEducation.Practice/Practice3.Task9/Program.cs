namespace Practice3.Task9
{
    internal class Program
    {
        static void ChangeName(Student student)
        {
            student.Name = "Anonimus";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя студента");
            string StudentName = Console.ReadLine();
            Console.WriteLine("Введите возвраст студента");
            int.TryParse(Console.ReadLine(), out int StudentAge);

            Student StudentInfo = new Student {Name = StudentName, Age = StudentAge};
            Console.WriteLine($"До {StudentInfo.Name}, ему {StudentInfo.Age} лет");
            ChangeName(StudentInfo);
            Console.WriteLine($"После {StudentInfo.Name}, ему {StudentInfo.Age} лет");
        }
    }
}
