namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Гипотенуза при наличии катетов
            double A = 10.2;
            double B = 12.5;
            double C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
            Console.WriteLine($"Значение гипотенузы: {C:F2}");

            // Определение катетов
            A = Math.Sqrt(Math.Pow(C, 2) - Math.Pow(B, 2));
            Console.WriteLine($"Значение катета: {A:F2}");
        }
    }
}
