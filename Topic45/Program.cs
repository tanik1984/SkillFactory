﻿using System;

namespace Topic45
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int k = 0; k < 3; k++)
            {
                (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age)
                    User;

                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                var resalt = Console.ReadLine();

                if (resalt == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя");

                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];

                Console.WriteLine("Введите три любимых цвета");

                for (int i = 0; i < 3; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
}
    

