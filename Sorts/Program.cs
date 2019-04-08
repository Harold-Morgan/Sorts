using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorts
{
    class Program
    {
        const int ARRAYLENGTH = 10;

        static void Main(string[] args)
        {
            int[] targetarray = new int[ARRAYLENGTH];
            Random randNum = new Random();

            for (int i = 0; i < targetarray.Length; i++)
                targetarray[i] = randNum.Next(0, 100);


            //TODO: Было бы круто замерять тайминги реализаций
            Console.WriteLine("Не отсортированный: ");
            Console.Write("[{0}]", string.Join(", ", targetarray));
            Console.WriteLine();

            Console.WriteLine("После сортировки выбором: ");
            Console.Write("[{0}]", string.Join(", ", Sorts.Sorter.SelectionSort(targetarray)));
            Console.WriteLine();

            Console.WriteLine("После сортировки вставкой: ");
            Console.Write("[{0}]", string.Join(", ", Sorts.Sorter.InsertionSort(targetarray)));
            Console.WriteLine();

            Console.WriteLine("После сортировки Шелла: ");
            Console.Write("[{0}]", string.Join(", ", Sorts.Sorter.ShellSort(targetarray)));
            Console.WriteLine();

            
            Console.WriteLine("После квиксорта: ");
            Console.Write("[{0}]", string.Join(", ", Sorts.quicksorter.quicksort(targetarray, 0, targetarray.Length - 1)));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
