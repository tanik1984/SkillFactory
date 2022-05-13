using System;

namespace Topic558
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PowerUp(5,3));
        }

        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }

                else
                {
                    return N * PowerUp(N, --pow);
                }

            }
        }
    }
}





        


    

