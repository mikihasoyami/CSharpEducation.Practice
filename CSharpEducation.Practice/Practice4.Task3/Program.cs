using System.ComponentModel;

namespace Practice4.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog TDog = new Dog("Петрушка", 3);
            Cat TCat = new Cat("Тыгыдык", 1);
            Parrot TParrot = new Parrot("Чудик", 1, "Синий");
            Console.WriteLine($"Собака говорит: {TDog.MakeSound()}");
            Console.WriteLine($"Кошка говорит: {TCat.MakeSound()}");
            Console.WriteLine($"Попугай говорит: {TParrot.MakeSound("Parrot is talking")}");

            Console.WriteLine();
            Console.WriteLine("=== По списку ===");

            List<Animal> Animals = new List<Animal>()
            {
                new Dog("Петрушка", 3),
                new Cat("Тыгыдык", 1),
                new Parrot("Чудик", 1, "Синий")
            };

            foreach (Animal TAnimal in Animals) 
            {
                string AnimalType = TAnimal.GetType().Name;
                Console.WriteLine($"\n--- Переопределение типов {AnimalType} ---");
                Console.WriteLine($"По умолчанию: \n{TAnimal.Sleep()}\n" +
                    $"{TAnimal.MakeSound()}\n" +
                    $"{TAnimal.Eat()}");

                if (TAnimal is Dog TTDog)
                { 
                    Console.WriteLine($"{TTDog.Sleep()}\n" +
                        $"{TTDog.MakeSound()}\n" +
                        $"{TTDog.Eat()}\n" +
                        $"{((Dog)TAnimal).Sleep()}\n" +
                        $"{((Dog)TAnimal).MakeSound()}\n" +
                        $"{((Dog)TAnimal).Eat()}");
                }
                else 
                if (TAnimal is Cat TTCat)
                {
                    Console.WriteLine($"{TTCat.Sleep()}\n" +
                        $"{TTCat.MakeSound()}\n" +
                        $"{TTCat.Eat()}\n" +
                        $"{((Cat)TAnimal).Sleep()}\n" +
                        $"{((Cat)TAnimal).MakeSound()}\n" +
                        $"{((Cat)TAnimal).Eat()}");
                }
                else 
                if (TAnimal is Parrot TTParrot)
                {
                    Console.WriteLine($"{TTParrot.Sleep()}\n" +
                        $"{TTParrot.MakeSound()}\n" +
                        $"{TTParrot.Eat()}\n" +
                        $"{((Parrot)TAnimal).Sleep()}\n" +
                        $"{((Parrot)TAnimal).MakeSound()}\n" +
                        $"{((Parrot)TAnimal).Eat()}");
                }

            }
        }
    }
}
