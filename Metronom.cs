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
        // Deklarace delegáta (v poznámkách podle Staňka)
        public event EventHandler Evie;
        
        /* public delegate void TickEventHadler(Metronom m, Event e);
         * public EventArgs e = null;
         */

        

        // Deklarace události
        //public event TickEventHandler Tick;

        // Metoda každé tři sekundy vyvolá událost Tick
        public void Start()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(3000);
                Evie(this, null);
                
            }

            /* while (true)
             * {
             *     Thread.Sleep(3000);
             *     Tick.Invoke(this, e);
             * }
             */
        }
    }

    // Odběratel
    class Listener
    {
        public void Já(object sauce, EventArgs e)
        {
            Console.WriteLine("Slyšela jsem to");
        }

        public void Registrace(Metronom m)
        {
            m.Evie += Já;
        }

        // Metodu pro obsluhu události
        /* private void Poslouchám(Metronom m, EventArgs e)
         * {
         *      Console.WriteLine();
         * }
         */

        // Metodu pro přihlášení k odběru
    }

    class Program
    {
        static void Main(string[] args)
        {

            Metronom m = new Metronom();
            Listener l = new Listener();

            l.Registrace(m);
            m.Start();









        }
    }
}
