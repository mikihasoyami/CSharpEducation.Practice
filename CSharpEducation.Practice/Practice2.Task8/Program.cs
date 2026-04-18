namespace Practice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод трех чисел с клавиатуры
            Console.WriteLine("Введите первое число:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int C = int.Parse(Console.ReadLine());

            // Проверка наличия хотя бы двух равных чисел
            if (A == B || A == C || B == C)
            {
                // Есть хотя бы две равные — увеличиваем все на 5
                A += 5;
                B += 5;
                C += 5;

                // Выводим результат
                Console.WriteLine($"Измененные значения: {A}, {B}, {C}");
            }
            else
            {
                // Нет равных — выводим сообщение
                Console.WriteLine("равных нет");
            }
        }
    }
}
