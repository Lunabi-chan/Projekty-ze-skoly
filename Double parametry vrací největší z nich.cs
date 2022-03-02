using System;

namespace ConsoleApp1
{
    
    class Program
    {
        public static void DAB(ref double d, double o, double u, double b)
        {
            if (d < o)
                d = o;
            if (d < u)
                d = u;
            if (d < b)
                d = b;

            return;
        }

        static void Main(string[] args)
        {
            Random dice = new Random();
            double a = dice.NextDouble();
            double b = dice.NextDouble();
            double c = dice.NextDouble();
            double d = dice.NextDouble();

            Console.WriteLine("Naše čísla: \n1.č: {0}\n2.č: {1}\n3.č: {2}\n4.č: {3}", a, b, c, d);
            DAB(ref a,b,c,d);
            Console.WriteLine("\nNejvětší číslo z nich: {0}", a);
        }
    }
}
