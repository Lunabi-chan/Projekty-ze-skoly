using System;

namespace ConsoleApp1
{
    
    class Program
    {
        public static int tisk(int a, int b, int c)
        { 
            if (a < b)
                a = b;   // a > b
            if (a < c)
                a = c;   // a > c > b
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("3 čísla a vytiskni to největší");

            Random dice = new Random();
            int a = dice.Next(1, 20);
            int b = dice.Next(1, 20);
            int c = dice.Next(1, 20);

            Console.WriteLine(" a = {0}\n b = {1}\n c = {2}", a, b, c);
            Console.WriteLine("Největší číslo: {0}", tisk(a, b, c));
        }
    }
}
