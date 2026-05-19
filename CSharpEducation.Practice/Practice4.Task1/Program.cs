using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace Practice4.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee("Иван", 1500));
            EmployeeList.Add(new Employee("Мария", 2000));
            EmployeeList.Add(new Contractor("Тест", 3000));
            EmployeeList.Add(new Contractor("Пётр", 5000));

            Console.WriteLine("=== По списку сотрудников и контрактников без кол-ва отработанных часов, по умолчанию 0 ===");
            foreach (Employee Emp in EmployeeList) 
            {
                Console.WriteLine($"{Emp.Name} бонус: {Emp.CalculateBonus()}");
            }
            Console.WriteLine();

            int HourseWorker = 160;
            Console.WriteLine("=== По списку контрактников со 160 отработанными часами ===");
            foreach (Employee Emp in EmployeeList) 
            {
                if (Emp is Contractor TContractor)
                {
                    double Bonus = TContractor.CalculateBonus(HourseWorker);
                    Console.WriteLine($"{TContractor.Name} бонус за {HourseWorker} часов: {Bonus}");
                }
            }

            Console.WriteLine();
            // Старые методы из пунктов a и b
            Console.WriteLine("=== Старые методы из пунктов a и b ===");
            Employee TEmployee = new Employee("Иван", 1500);
            Manager TManager = new Manager("Мария", 2000, 1);
            Manager TManager2 = new Manager("Дмитрий", 5000, 6);
            Console.WriteLine($"Имя: {TEmployee.Name}, Кол-во бонусов: {TEmployee.CalculateBonus()}");
            Console.WriteLine($"Имя: {TManager.Name}, Кол-во бонусов: {TManager.CalculateBonus()}");
            Console.WriteLine($"Имя: {TManager2.Name}, Кол-во бонусов: {TManager2.CalculateBonus()}");
        }
    }
}
