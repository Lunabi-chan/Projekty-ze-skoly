using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp_1
{
    // Použiju generický delegát
    // public delegate void Dell();

    // Class Publisher
    class Vydavatel
    {
        public event EventHandler OngOng;                   // Z m ě n a - přidání EventHandler

        // Vyvolání události
        public void Start()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 9 == 0 && OngOng != null)
                {
                    OngOng(this, null);                     // Z m ě n a - přidány parametry do závorky
                    Console.WriteLine(i);
                }
                    
            }
        }
    }

    // Class Subscriber
    class Předplatitel
    {
        public void Obsluha(object sauce, EventArgs e)      // Z m ě n a - přidány parametry do závorky
        {
            Console.WriteLine("Číslo je dělitelné 9.");
        }

        public void Registrace(Vydavatel v)
        {
            v.OngOng += Obsluha;                            // Z m ě n a - byla smazána 'new Dell' před Obsluhou
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
