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
            int[] pole = new int[] { 44, 55, 12, 42, 94, 18, 10, 6 };

            int pom;
            
            for (int i = 0; i <= pole.Length; i++)
            {
                if (pole[i] > pole[i + 1])
                {
                    pom = pole[i];
                    pole[i] = pole[i + 1];
                    pole[i + 1] = pom;

                    i = -1;
                }

                

                Console.WriteLine();
            }

            for (int k = 0; k < pole.Length - 1; k++)
            {
                Console.Write("{0}\t", pole[k]);
            }
            /*
            int vkladany;
            int j;
            
            for (int i = 1; i < pole.Length; i++)
            {
                vkladany = pole[i];
                j = i - 1;
                while((j>=0)&&(vkladany < pole[j]))
                {
                    pole[j + 1] = pole[j];
                    j--;
                }

                pole[j + 1] = vkladany;
                
            }

            for (int k = 0; k < pole.Length; k++)
            {
                Console.Write("{0}\t", pole[k]);
            }*/

            Console.WriteLine();
        }
    }
}
