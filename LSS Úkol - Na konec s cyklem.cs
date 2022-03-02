using System;

namespace LSS
{
    /*
     * Vytvoření spojového 
     */
    public class Prvek
    {
        public int hodnota;
        public Prvek p_dalsi;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Prvek p_novy = null;
            Prvek p_seznam = null;
            Prvek p_konec = null;

            p_seznam = new Prvek();
            p_seznam.hodnota = 1;
            p_seznam.p_dalsi = null;          //nebo p_novy.p_dalsi = p_seznam;
            p_konec = p_seznam;

            for (int i = 2; i <= 10; i++)
            {
                p_novy = new Prvek();
                p_novy.hodnota = i;
                p_konec.p_dalsi = p_novy;
                p_konec = p_novy;
            }

            while (p_seznam != null)
            {
                Console.Write("{0,5}", p_seznam.hodnota);
                p_seznam = p_seznam.p_dalsi;
            }

            Console.ReadLine();
        }
    }
}
