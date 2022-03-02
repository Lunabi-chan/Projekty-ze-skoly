﻿using System;

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

            p_novy = new Prvek();
            p_novy.hodnota = 1;
            p_novy.p_dalsi = null;          //nebo p_novy.p_dalsi = p_seznam;
            p_seznam = p_novy;

            for (int i = 2; i <= 10; i++)
            {
                p_novy = new Prvek();
                p_novy.hodnota = i;
                p_novy.p_dalsi = p_seznam;
                p_seznam = p_novy;
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
