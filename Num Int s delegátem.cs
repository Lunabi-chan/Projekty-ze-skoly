using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp_1
{
    public delegate double Dell(double x);

    class Funkce
    {
        static public double f1(double x)
        {
            return Math.Sin(x);
        }

        static public double f2(double x)
        {
            return Math.Cos(x);
        }

        static public double f3(double x)
        {
            return x;
        }
    }

    class Program
    {
        static double LichoběžníkovoPravidlo(double a, double b, double n, Dell f)
        {
            double součet = 0;      // součet fčních hodnot
            double x = a;           // bod, ve kterém se počítá fční hodnota pomocné proměnné pro výpočet

            double krokH = (b - a) / n;     // dělení intervalu
            součet = (f(a) + f(b)) / 2;     // 

            for (int i = 1; i < n; i++)
            {
                x += krokH;
                součet += f(x);
            }

            return součet * krokH;
        }

        static double SimpsonovoPravidlo(double a, double b, double n, Dell f)
        {
            double součet = 0;      // součet fčních hodnot
            double x = a;           // bod, ve kterém se počítá fční hodnota pomocné proměnné pro výpočet

            double krokH = (b - a) / n;     // dělení intervalu
            součet = f(a) + f(b);           // vložení fčních hodnot v krajních bodech intervalu

            for (int i = 1; i < n; i++)
            {
                x += krokH;

                if (i % 2 == 0) // (modulo)
                    součet += 2 * f(x);
                if (i % 2 != 0) // else
                    součet += 4 * f(x);
            }

            return součet * krokH/3;
        }

        static void Parametry(ref double a, ref double b, ref double n)
        {
            Console.Write("\n Zadej horní mez intervalu: ");
            a = double.Parse(Console.ReadLine());
            Console.Write(" Zadej dolní mez intervalu: ");
            b = double.Parse(Console.ReadLine());
            Console.Write(" Zadej dělení intervalu: ");
            n = double.Parse(Console.ReadLine());
        }

        static void Tisk(double a, double b, double n, Dell f)
        {
            Console.WriteLine($"\n\tObsah obrazce ohraničeném grafem fce a osou x na intervalu <{a}; {b}> je: ");
            Console.WriteLine("\t Lichoběžníkovým pravidlem: {0}", LichoběžníkovoPravidlo(a, b, n, f));
            Console.WriteLine("\t Simpsonovým pravidlem: {0}", SimpsonovoPravidlo(a, b, n, f));
        }

        static void Main(string[] args)
        {
            int choice = 0;
            while (choice == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\t NUMERICKÁ INTEGRACE");

                Console.WriteLine("Výběr funkce: \n 1.) y = sinx \n 2.) y = cosx \n 3.) y = x \n 4.) Ukončit program \n---------------------------");
                Console.Write("Vaše volba: ");
                string e = Console.ReadLine(); // výběr fce

                Dell f = new Dell(Funkce.f1);

                switch (e)
                {
                    case "1": 
                        f = Funkce.f1;
                        break;
                    case "2":
                        f = Funkce.f2;
                        break;
                    case "3":
                        f = Funkce.f3;
                        break;
                    case "4":
                        choice = 1; Environment.Exit(0); //nebo return
                        break;

                    default: Console.WriteLine("\n\tZadali jste špatnou/nezadanou hodnotu."); Console.ReadLine(); continue;
                }

                double a = 0;
                double b = 0;
                double n = 0;

                Parametry(ref a, ref b, ref n);
                Tisk(a, b, n, f);
                

                Console.ReadLine();
            }

        }
    }
}
