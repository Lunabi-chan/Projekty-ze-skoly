using System;
using System.IO;

namespace ConsoleApp1
{
    
    class Program
    {   
        static void Main(string[] args)
        {
            /*
             * Program zpracovává vstupní soubor, obsahující celá čísla a znaky, oddělené bílými znaky. 
             * Čísla vypisuje na obrazovku i s jejich pořadovým číslem v souboru, 
             * při načtení prvního znaku „ne-čísla“ zpracování souboru končí.
             */
            string cesta = @"\\regulus2\kopírka\VTS4\celáAZnaky.txt";

            if (!File.Exists(cesta))
            {
                Console.WriteLine("Soubor neexistuje");
                return;
            }
            /*
            using (StreamReader SR = new StreamReader(cesta))
            {
                string řádek;   bool result;    int počet = 1;    int číslo;

                while ((řádek = SR.ReadLine()) != null)
                {
                    řádek = řádek.Trim();
                    string[] pole = řádek.Split(' ', '\n', '\t');

                    for (int i = 0; i < pole.Length; i++)
                    {
                        if (pole[i] == "") continue;
                        result = int.TryParse(pole[i], out číslo);
                        if (result)
                            Console.WriteLine("{0} = {1}", počet, číslo);
                        else
                        {
                            Console.WriteLine("Není číslo!");
                            return;
                        }
                        počet++;
                    }
                }
            }*/

            using (StreamReader SR = new StreamReader(cesta))
            {
                string h;
                while ((h = SR.ReadLine()) != null)
                {
                    foreach (char c in h)
                    {
                        if (System.Convert.ToInt32(c) > 47 && System.Convert.ToInt32(c) < 58)
                        {
                            Console.WriteLine("{0}", System.Convert.ToInt32(c));
                        }
                        else
                        {
                            Console.WriteLine("Není číslo!");
                            return;
                        }
                    }
                    Console.ReadKey();
                    /*foreach (char c in h)
                    {
                        if (System.Convert.ToInt32(c) > 47 && System.Convert.ToInt32(c) < 58)
                        {
                            Console.WriteLine("Údaj číslo {0}: {1}", i, System.Convert.ToInt32(c));
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("Není číslo!");
                            continue;
                        }
                    }
                     */
                }

            }





        }
    }
}
