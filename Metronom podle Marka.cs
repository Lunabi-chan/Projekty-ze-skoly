using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            // metronom m1 tiskne každou vteřinu a spustí M1Tick
            Metronome m1 = new Metronome(1000);
            m1.SetOnTickListener(M1Tick);
            m1.Start();

            Console.ReadLine();
            m1.Stop();
            Console.ReadLine();
            //------------------------------------------------------------

            // metronom m2 tiskne každou vteřinu a spustí vlastní fci
            Metronome m2 = new Metronome(500);
            m2.SetOnTickListener(() => {
                Console.WriteLine("M2 tiknul");
            });
            m2.Start();

            Console.ReadLine();
            m2.Stop();
            Console.ReadLine();
            //------------------------------------------------------------

            // metronom m1 a m2 současně
            m1.Start();
            m2.Start();

            Console.ReadLine();

            m1.Stop();
            m2.Stop();

            Console.ReadLine();
            //------------------------------------------------------------

            // metronom mm tiskne každou 1/3 vteřiny a spouští dvě metody
            Multimetronome mm = new Multimetronome(333);
            mm.AddOnTickListener(() => {
                Console.WriteLine("M2 tiknul");
            });
            mm.AddOnTickListener(M1Tick);
            mm.Start();

            Console.ReadLine();
            mm.Stop();
            Console.ReadLine();

            Console.ReadLine();
        }

        private static void M1Tick()
        {
            Console.WriteLine("M1 tiknul");
        }
    }
}
