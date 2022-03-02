using System;
using System.IO;

namespace ConsoleApp1
{
    
    class Program
    {
        /* Program zpracovává vstupní soubor, obsahující celá i reálná čísla a znaky, oddělené bílými znaky. 
         * Čísla vypisuje na obrazovku i s jejich pořadovým číslem v souboru, 
         * při načtení ne-čísla zpracování souboru končí.
         */
        static void Main(string[] args)
        {
            string cesta = @"\\regulus2\kopírka\VTS3\VTS4\cislaAznaky2.txt";

            if (!File.Exists(cesta))
            {
                Console.WriteLine("Soubor neexistuje");
                return;
            }

            using (StreamReader SR = new StreamReader(cesta))
            {
                string řádek; bool result; 
                double počet = 1; double číslo;
                int poč = 1; double čís;

                while ((řádek = SR.ReadLine()) != null)
                {
                    řádek = řádek.Trim();
                    string[] pole = řádek.Split(' ', '\n', '\t');

                    foreach (string a in pole)
                    {
                        if (a == "") continue;
                            result = double.TryParse(a, out číslo);
                        
                        if (result)
                            Console.WriteLine("{0} = {1}", počet, číslo);
                        
                        else
                        {
                            continue;
                        }
                        počet++;
                    }
                }

            }
        }
    }
}
