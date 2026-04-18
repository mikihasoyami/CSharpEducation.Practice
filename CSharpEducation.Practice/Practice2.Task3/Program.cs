namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение A");
            bool ChechedA = false;
            float.TryParse(Console.ReadLine(), out float A);

            while (true)
            {
                if (A == 0)
                {
                    Console.WriteLine("A не может быть равна 0, введите другое значение");
                    float.TryParse(Console.ReadLine(), out A);
                }
                else
                {
                    ChechedA = true;
                    break;
                }
            }

            if (ChechedA)
            {
                Console.WriteLine("Введите значение B");
                float.TryParse(Console.ReadLine(), out float B);
                Console.WriteLine("Введите значение F");
                float.TryParse(Console.ReadLine(), out float F);
                float X = (A + B - F / A) + F * A * A - (A + B);
                Console.WriteLine($"Значение X={X}");
            }
        }
    }
}
