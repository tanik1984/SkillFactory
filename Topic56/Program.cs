using System;

namespace Topic56
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var userInfo = RequestUserInfo();

            ShowUserInfo(userInfo);
        }

        private static string RequestString(string message)
        {
            Console.Write(message);

            var value = Console.ReadLine();

            return value;
        }

        private static int RequestInt()
        {
            Console.Write("Введите возраст: ");

            while (true)
            {
                var value = Console.ReadLine();
                var isParsed = int.TryParse(value, out var age);
                if (isParsed == true && age > 0)
                {
                    return age;
                }

                Console.Write("Введено некорректное значение. Повторите ввод: ");
            }
        }

        private static bool RequestBool()
        {
            throw new NotImplementedException();
        }

        private static (string name, string surname, int age) RequestUserInfo()
        {
            var name = RequestString("Введите имя: ");
            var surname = RequestString("Введите фамилию: ");
            var age = RequestInt();
            var hasPet = RequestBool();

            Console.WriteLine("Has pet: {0}", hasPet);

            return (name, surname, age);
        }

        private static void ShowUserInfo((string name, string surname, int age) userInfo)
        {
            Console.WriteLine();
            Console.WriteLine("Имя: {0}", userInfo.name);
            Console.WriteLine("Фамилия: {0}", userInfo.surname);
            Console.WriteLine("Возраст: {0}", userInfo.age);
        }
    }
}