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

        static void SpeciálníTisk(int[] pole)
        {

            for (int k = 1; k < pole.Length; k++)
            {
                Console.Write("{0,5}", pole[k]);
            }
            Console.WriteLine();
        }

        static void Tisk(int[] pole)
        {

            for (int k = 0; k < pole.Length; k++)
            {
                Console.Write("{0,5}", pole[k]);
            }
            Console.WriteLine();
        }

        static void Select(int[] pole)
        {
            int pom1;
            int minnimalni;

            for (int i = 0; i < pole.Length; i++)
            {
                minnimalni = i;
                for (int j = i + 1; j < pole.Length; j++)
                {
                    if (pole[j] < pole[minnimalni])
                    {
                        minnimalni = j;
                    }

                    pom1 = pole[i];
                    pole[i] = pole[minnimalni];
                    pole[minnimalni] = pom1;

                }
                Tisk(pole);
            }
        }

        static void Insert(int[] pole)
        {
            int vkladany;
            int j;

            for (int i = 0; i < pole.Length; i++)
            {
                vkladany = pole[i];
                j = i - 1;
                while ((j >= 0) && (vkladany < pole[j]))
                {
                    pole[j + 1] = pole[j];
                    j--;
                }
                pole[j + 1] = vkladany;
                Tisk(pole);

            }
        }

        static void Bubble(int[] pole)
        {
            int pom;
            for (int i = 1; i < pole.Length; i++)
            {
                for (int j = pole.Length -1; j >= i; j--)
                {
                    if (pole[j-1]>pole[j])
                    {
                        pom = pole[j];
                        pole[j] = pole[j - 1];
                        pole[j - 1] = pom;
                    }
                }
                Tisk(pole);
            }
        }

        static void InsertZarážka(int[] pole)
        {
            int j;              // Index seříděné posloupnosti

            for (int i = 2; i < pole.Length; i++)       //První prvek p[1], i == 2 začínáme od 2. prvku
            {
                pole[0] = pole[i];              // Nastavíme zarážku podle zařazovaného prvku
                j = i - 1;                      // Index je největší seříděný prvek 
                while (pole[0] < pole[j])
                {                                       //Dokud nejsme u prvního prvku a vkládaný prvek je menší
                    pole[j + 1] = pole[j];                 //posuneme prvek o jedno místo doprava
                    j--;                                   //v nesetříděné posloupnosti zmenšíme index - posuneme se o jedno místo doleva
                }
                pole[j + 1] = pole[0];              //Vkládaný prvek (schovaný v zarážce) vložíme na správné volné místo
                SpeciálníTisk(pole);                                //provedeme kontrolní tisk pole
            }
        }

        static void QuickSort(int[] pole, int zač, int kon)
        {
            int pom;
            int i = zač;
            int j = kon;
            int pivot = pole[(i + j) / 2]; // Pivot jako prostřední prvek řazeného úseku

            do
            {
                while (pole[i] < pivot) i++;
                while (pole[j] > pivot) j--;
                if (i < j)        // Výměna prvků s indexy i a j
                {
                    pom = pole[i];
                    pole[i] = pole[j];
                    pole[j] = pom;

                    i++; j--;       //Posun indexů na další prvky
                }

                else if (i == j)        //Oba indexy se sešly; oba ukazují na pivota
                {
                    i++;
                    j--;
                }
                Tisk(pole);

            } while (i < j);

            /* Úsek <zač; kon> je rozdělen na úseky <zač, j> a <i, kon>
             * na které rekurzívně použijeme metodu QuickSort */
            if (zač < j) QuickSort(pole, zač, j);
            if (i < kon) QuickSort(pole, i, kon);
        }

        static void Main(string[] args)
        {
            int[] pole = new int[] { 44, 55, 12, 42, 94, 18, 10, 6 };
            
            Console.WriteLine("Selection Sort");
            Select(pole);
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Insert Sort");
            pole = new int[] { 44, 55, 12, 42, 94, 18, 10, 6 };
            Insert(pole);
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Insert Sort se zarážkou");
            pole = new int[] { int.MaxValue, 44, 55, 12, 42, 94, 18, 10, 6 };
            InsertZarážka(pole);
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Bubble Sort");
            pole = new int[] { 44, 55, 12, 42, 94, 18, 10, 6 };
            Bubble(pole);
            Console.WriteLine("\n\n\n");

            Console.WriteLine("Quick Sort");
            pole = new int[] { 44, 55, 12, 42, 94, 18, 10, 6 };
            QuickSort(pole, 0, pole.Length - 1);
            Console.WriteLine("\n\n\n");
        }
    }
}
