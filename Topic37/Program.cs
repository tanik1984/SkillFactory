using System;

namespace Topic37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");

            var name = Console.ReadLine();

            Console.Write("Enter your age:");

            var ageValue = Console.ReadLine();

            var age = byte.Parse(ageValue);

            Console.WriteLine("Your name is {0} and age is {1}", name, age);

            Console.Write("Enter your birthday:");

            var birthday = Console.ReadLine();

            Console.WriteLine("Your birthday is {0}", birthday);

        }
    }
}
