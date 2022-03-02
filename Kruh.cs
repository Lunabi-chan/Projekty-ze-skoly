using System;

namespace ConsoleApp1
{
    
    class Program
    {
        public static void Kruh(int r, ref double o, ref double S)
        { 

        }

        static void Main(string[] args)
        {
            Random dice = new Random();
            int r = dice.Next(1, 20);
            double o = 0; double S = 0;

            Console.WriteLine("Poloměr = {0}", r);
            Kruh(r, ref o, ref S);
        }
    }
}
