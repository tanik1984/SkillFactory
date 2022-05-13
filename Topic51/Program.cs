using System;
using System.Globalization;

namespace Topic51
{
    class Program
    {
        static void Main(string[] args)
        {
            var someAgg = 28;

            Console.WriteLine(someAgg);

            ChangeAge(ref someAgg);

            Console.WriteLine(someAgg);

            //    var favcolors = new string[3];

            //    for (var i = 0; i < favcolors.Length; i++)
            //    {
            //        favcolors[i] = ShowColor("");
            //    }

            //    foreach (var favcolor in favcolors)
            //    {
            //        Console.WriteLine(favcolor);
            //    }


            var size = 6;
            var rawNumber = GetArrayFromConsole(ref size);

            //SortArray(rawNumber);

            foreach (var number in rawNumber)
            {
                Console.WriteLine(number);
            }


            //    var pupils = new int[100];
            //    var salaries = new int[1000000];

            //    SortArray(pupils);
            //    SortArray(salaries);
            //}


            //static string ShowColor(string username)
            //{
            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //    var color = Console.ReadLine();

            //    switch (color)
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;


            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Your color is Yellow!");
            //            break;
            //    }

            //    return color;
            //}

            static int[] GetArrayFromConsole(ref int size)
            {
                var result = new int[size];

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                return result;
            }

            //static void SortArray(int[] numbers)
            //{
            //    for (var i = 0; i < numbers.Length; i++)
            //    {
            //        for (var k = 0; k < numbers.Length-1; k++)
            //        {
            //            if (numbers[k]>numbers[k+1])
            //            {
            //                var temp = numbers[k + 1];
            //                numbers[k + 1] = numbers[k];
            //                numbers[k] = temp;
            //            }
            //        }
            //    }
            //}
        }

        static void ChangeAge(ref int age)
        {
            Console.WriteLine("Введите возраст");
            age = int.Parse(Console.ReadLine());
        }


    }
}



