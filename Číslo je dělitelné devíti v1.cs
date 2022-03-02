using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp_1
{
    public delegate void Dell();

    // Class Publisher
    class Vydavatel
    {
        public event Dell OngOng;           // Deklarace události

        // Vyvolání události
        public void Start()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 9 == 0 && OngOng != null)
                {
                    OngOng();
                    Console.WriteLine(i);
                }
                    
            }
        }
    }

    // Class Subscriber
    class Předplatitel
    {
        public void Obsluha()
        {
            Console.WriteLine("Číslo je dělitelné 9.");
        }

        public void Registrace(Vydavatel v)
        {
            v.OngOng += new Dell(Obsluha);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vydavatel v = new Vydavatel();
            Předplatitel p = new Předplatitel();

            p.Registrace(v);
            v.Start();













        }
    }
}
