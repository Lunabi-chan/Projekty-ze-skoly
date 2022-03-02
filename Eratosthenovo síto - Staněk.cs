using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] matrix = new int[600];
            int j, ra, sl;

            Console.Clear();

            Console.WriteLine("Erathostenovo síto\n\n\n");
            // Vytvoření matice
            for (int i = 2; i < matrix.Length; i++)
            {
                matrix[i] = i;
                Console.Write("{0,4}", matrix[i]);                
            }
            Console.WriteLine("");
            Console.ReadLine();

            // Tisk matice
            for (int i = 2; i < matrix.Length; i++)
            {
                if (matrix[i] != 0)
                {
                    j = i + i;
                    while (i < matrix.Length)
                    {
                        if((matrix[j] % i) == 0)
                            matrix[j] = 0;
                        sl = ((4 * j - 7) % 80);
                        ra = (4 + (4 * j - 7) / 80);
                        Console.CursorLeft = sl;
                        Console.CursorTop = ra;
                        Console.Write("     ");
                        System.Threading.Thread.Sleep(10);
                        j = j + i;
                    }
                }
                Console.WriteLine();
            }
           
        }

    }  
}
