using System;

namespace ConsoleApp1
{
    
    class Program
    {
        public static bool PH(int x)
        {
            int součet = 1;
            int dělitel = 2;

            /* // Moje řešení
            for (int i = 1; i < (x / 2 + 1); i++)
            {
                if (x % dělitel == 0)
                {
                    součet += dělitel;
                    dělitel++;
                }
                else dělitel++;
            }
            
            if (součet == x)
                return true;
            else return false;
             */

            // Řešení profesora
            if (x == 1)
                return false;

            while (x/2 >= dělitel)
            {
                if (x % dělitel == 0)
                    součet += dělitel;
                dělitel++;
            }

            return součet == x;
            
        }
        static void Main(string[] args)
        {
            for (int i = 2; i < 10000; i++)
            {
                if (PH(i))
                    Console.WriteLine(i + " je dokonalé.");
            }

            Console.WriteLine();
        }
    }
}
