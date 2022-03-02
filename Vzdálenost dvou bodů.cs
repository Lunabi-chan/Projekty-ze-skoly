using System;

namespace ConsoleApp1
{
    
    class Program
    {
        public static void Vzd(double a, double b, double c, double d)
        {
            Console.WriteLine("Vzdálenost mezi bodem A a B je: {0}", Math.Sqrt(Math.Pow(c-a,2) + Math.Pow(d-b,2)));
        }

        static void Main(string[] args)
        {
            Random dice = new Random();
            double a1 = dice.Next(1, 20);
            double a2 = dice.Next(1, 20); 
            double b1 = dice.Next(1, 20); 
            double b2 = dice.Next(1, 20);

            Console.WriteLine("A[{0}, {1}] \nB[{2}, {3}]", a1,a2,b1,b2);
            Vzd(a1, a2, b1, b2);
        }
    }
}
