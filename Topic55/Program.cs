﻿using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Topic55
{
    class Program
    {



        //    Console.WriteLine("Напишите что-то");

        //     var str = Console.ReadLine();

        //     Console.WriteLine("Укажите глубину эха");

        //     var deep = int.Parse(Console.ReadLine());

        //     Echo(str, deep);

        //}

        //static void Echo(string saidword, int deep)
        //{
        //    var modif = saidword;

        //    if (modif.Length > 2)
        //    {
        //        modif = modif.Remove(0,2);
        //    }

        //    Console.BackgroundColor = (ConsoleColor) deep;
        //    Console.WriteLine("..." + modif);

        //    if (deep > 1)
        //    {
        //        Echo(modif,deep-1);
        //    }


        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());


            decimal f = Factorial(x);

            Console.WriteLine(f);

        }
        static decimal Factorial(int x)
        {

            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }


        }
    }
}