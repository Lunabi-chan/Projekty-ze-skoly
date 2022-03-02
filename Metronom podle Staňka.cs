using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Threading;

namespace ConsoleApp_1
{
    /*
        Naprogramujte:
            třídu Metronom, která vytvoří událost: každé 3 sekundy vyvlá Tick
            třídu Listener, která slyší Tick Metronomu a tiskne do konzoli "Slyšel jsem to!" kdykoliv obdrží událost
     */

    class Metronom
    {
        // Deklarace delegáta       
        public delegate void TickEventHandler(Metronom m, EventArgs e);
        public EventArgs e = null;
        

        // Deklarace události
        public event TickEventHandler Tick;

        // Metoda každé tři sekundy vyvolá událost Tick
        public void Start()
        {
            while (true)
            {
                Thread.Sleep(3000);
                Tick.Invoke(this, e);
            }
        }
    }

    // Odběratel
    class Listener
    {
        // Metodu pro obsluhu události
        private void Poslouchám(Metronom m, EventArgs e)
        {
            Console.WriteLine("Slyšela jsem to!");
        }

        // Metodu pro přihlášení k odběru
        public void Registrace(Metronom m)
        {
            //m.Tick += new Metronom.TickEventHandler(Poslouchám);
            m.Tick += Poslouchám;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instance vydavatele
            Metronom m = new Metronom();

            // Instance odběratele
            Listener l = new Listener();

            // Přihlášení k odběru
            l.Registrace(m);

            // Vyvolání události
            m.Start();
        }
    }
}
