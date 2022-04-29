using System;

namespace Topic43
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Введите свое имя");

            //string name = Console.ReadLine();

            //Console.WriteLine("Ваше имя по буквам:");

            //foreach (var letter in name)
            //{

            //    Console.Write(letter+" ");
            //}

            //var length = name.Length;

            //var lastLetter = name[length-1];

            //Console.WriteLine("Последняя буква вашего имени: "+lastLetter);

            //for (int i = length-1; i >=0; i--)
            //{
            //    Console.Write(name[i]+" ");

            //}

            //int[,] array = {{1, 2, 3}, {5, 6, 7}};

            //foreach (var i in array)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(array.GetUpperBound(0));
            //Console.WriteLine(array.GetUpperBound(1));

            //int[,] numbers =
            //{
            //    {1, 2, 3}, 
            //    {5, 6, 7}, 
            //    {8, 9, 10}, 
            //    {11, 12, 13}
            //};

            //for (var itemIndex = 0; itemIndex <= numbers.GetUpperBound(1); itemIndex++)
            //{
            //    for (var subArrayIndex = 0; subArrayIndex <= numbers.GetUpperBound(0); subArrayIndex++)
            //    {
            //        var number = numbers[subArrayIndex, itemIndex];

            //        Console.Write(number + " ");
            //    }

            //    Console.WriteLine();
            //}

            //var array = new[] {5, 6, 9, 1, 2, 3, 4};


            //int temp;

            //for (var round = 0; round < 7; round++)
            //{
            //    for (var i = 0; i < array.Length - 1; i++)
            //        if (array[i] > array[i + 1])
            //        {
            //            temp = array[i];

            //            array[i] = array[i + 1];

            //            array[i + 1] = temp;
            //        }
            //}



            //foreach (var num in array)
            //{
            //    Console.Write(num);
            //}

            //Console.WriteLine();

            //int sum = 0;

            //foreach (var number in array)
            //{
            //    sum += number;
            //}

            //Console.WriteLine(sum);

            //int[][] array = new int[3][];

            //array[0] = new int[2] { 1, 2 };
            //array[1] = new int[3] { 1, 2, 3 };
            //array[2] = new int[5] { 1, 2, 3, 4, 5 };

            //foreach (var subArray in array)
            //{
            //    foreach (var item in subArray)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}

            //var numbers = new int[,] {{4, -8, 7, -9, 2, -6}, {4, -8, 7, -9, 2, -6}, {4, -8, 7, -9, 2, -6}};

            //var count = 0;
            //foreach (var number in numbers)
            //{
            //    if (number > 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            int[,] arr =
            {
                { -5, 6, 9, 1, 2, -3 }, // q=0
                { -8, 8, 1, 1, 2, -3 }  // q=1
            };

            for (var q = 0; q < arr.GetUpperBound(0); q++)
            {



                int temp;

                for (var round = 0; round < arr.GetUpperBound(1); round++)
                {
                    for (var i = 0; i < arr.GetUpperBound(1) - 1; i++)
                        if (arr[q,i] > arr[q,i + 1])
                        {
                            temp = arr[q,i];

                            arr[q,i] = arr[q,i + 1];

                            arr[q,i + 1] = temp;
                        }
                }




            }
        }

    }
}