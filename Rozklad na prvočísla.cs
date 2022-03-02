using System;

namespace ConsoleApp1
{
    
    class Program
    {
        public static void lilprime(int a)
        {
            int d = 2;
            while(a > 1)
            {
                if (a % d == 0)
                {
                    Console.Write(" {0}", d);
                    a /= d;
                }
                else d++;
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Rozklad na prvočísla!");

            Random dice = new Random();
            int x = dice.Next(10,300);
            lilprime(x);

            Console.WriteLine(x);
            int d = 2;
            while (x > 1)
            {
                if (x % d == 0)
                {
                    Console.Write(" {0}", d);
                    x /= d;
                }
                else d++;
            }
            Console.WriteLine();

            /*
             * 1. Načti rozkládané číslo
             * 2. Cyklus Dokud > 1
             *    - vyděl prvočíslem a když je dělitelné beze zbytku
             */


        }
    }
}
