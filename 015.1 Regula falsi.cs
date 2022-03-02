using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_1
{
    class Program
    {
        public static double RegulaFalsi(double a, double b, int poč, double xs)
        {
            double x = a - ((b - a) / (f(b) - f(a)) * f(a));
            double p = Math.Abs(x-xs);

            Console.WriteLine("\t" + poč + "\n\t\ta: \t" + a + "\n\t\tb: \t" + b + "\n\t\tx: \t" + x + "\n\t\tp: \t" + p);
            Console.WriteLine("\n");
            poč++;

            xs = x;

            if (x < p || p == 0)
            {
                return 1;
            }
            if ((f(a) * f(x)) <= 0)
            {
                a = x;
                return RegulaFalsi(a, b, poč,xs);
            }
            if ((f(a) * f(x)) > 0)
            {
                b = x;
                return RegulaFalsi(a, b, poč,xs);
            }
            else
                return 1;
        }

        static public double f(double x)
        {
            return Math.Pow(x, 3) + 4*Math.Pow(x,2) - 10;
        }

        static void Main(string[] args)
        {
            double a = 1;
            double b = 2;

            double test = 0;
            
            int poč = 1;

            /*if (a > b)
                Console.WriteLine("Špatná hodnota, a musí být menší jak b.");
            else*/
            RegulaFalsi(a, b, poč, test);
            
            Console.ReadLine();

            // a - ((b-a)/(f(b)-f(a))) * f(a)
        }
    }
}
