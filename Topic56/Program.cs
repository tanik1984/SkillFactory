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

        private static int RequestInt(string message)
        {
            Console.Write(message);

            while (true)
            {
                var value = Console.ReadLine();
                var isParsed = int.TryParse(value, out var number);
                if (isParsed == true && number > 0)
                {
                    return number;
                }

                Console.Write("Введено некорректное значение. Повторите ввод: ");
            }
        }

        private static bool RequestBool()
        {
            Console.Write("Есть ли у Вас питомец (да/нет)? ");

            var value = Console.ReadLine();

            if (value.ToLower() == "yes" || value.ToLower() == "да") 
                return true;

            return false;
        }

        private static string[] RequestPetNames(int count)
        {
            var names = new string[count];

            for (var i = 0; i < names.Length; i++) 
                names[i] = RequestString("Введите имя питомца №" + (i + 1) + ": ");

            return names;
        }

        private static (string name, string surname, int age, string[] petNames) RequestUserInfo()
        {
            var name = RequestString("Введите имя: ");
            var surname = RequestString("Введите фамилию: ");
            var age = RequestInt("Введите возраст: ");
            var hasPet = RequestBool();

            var petNames = new string[0];

            if (hasPet == true)
            {
                var petCount = RequestInt("Введите количество питомцев: ");
                petNames = RequestPetNames(petCount);
            }

            return (name, surname, age, petNames);
        }

        private static void ShowUserInfo((string name, string surname, int age, string[] petNames) userInfo)
        {
            Console.WriteLine();
            Console.WriteLine("Имя: {0}", userInfo.name);
            Console.WriteLine("Фамилия: {0}", userInfo.surname);
            Console.WriteLine("Возраст: {0}", userInfo.age);

            if (userInfo.petNames.Length == 0)
            {
                Console.WriteLine("Питомцев нет");
            }
            else
            {
                Console.WriteLine("Питомцев: {0}", userInfo.petNames.Length);

                foreach (var name in userInfo.petNames)
                    Console.WriteLine("\t{0}", name);
            }
        }
    }
}