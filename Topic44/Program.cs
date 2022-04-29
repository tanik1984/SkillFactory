using System;

namespace Topic44
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCout) Pet;

            Console.WriteLine("Ведите имя питомца");
            Pet.Name = Console.ReadLine();
            Pet.NameCout = Pet.Name.Length;
            Console.WriteLine("Длина его имени: {0}", Pet.NameCout);

            Console.WriteLine("Введите вид питомца");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("введите возраст питомца");
            Pet.Age = double.Parse(Console.ReadLine());



        }
    }
}
