using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        /*Je dán vstupní textový soubor s komentáři uzavřenými do { }.
        /Vytvořte kopii tohoto souboru bez komentářů.*/
        static void Main(string[] args)
        {
            string cesta = @"\\regulus2\kopírka\VTS4\AAA.txt"; // Cesta do textu

            if (!File.Exists(cesta)) // Určení existence souboru
            {Console.WriteLine("Soubor neexistuje.");return;}


            using (StreamReader SR = new StreamReader(cesta))
            {
                string řádek;
                while ((řádek = SR.ReadLine()) != null)
                {
                    řádek = řádek.Trim(' ', '\n', '\t');
                    string[] pole = řádek.Split('{', '}');
                    SR.Close();
                    Console.Write("\n" + pole);


                    /*foreach (string pp in pole)
                    {
                        if (pp.StartsWith("{"))
                        {
                            string ayy = pp;
                            while (pp != "}")
                            {
                                for (int i = 0; i < pp[pp.Length - 1]; i++)
                                pole = pp.Remove(0);
                            }
                        }
                        else continue;
                    }*/

                    Console.Write(pole);
                }
            }
            
        }
    }
}
