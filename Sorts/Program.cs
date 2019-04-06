using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorts
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] targetarray = new int[10];
            int[] SortedArray = new int[10];
            Random randNum = new Random();

            for (int i = 0; i < targetarray.Length; i++)
                targetarray[i] = randNum.Next(0, 100);


            Console.WriteLine("Не отсортированный: ");
            Console.Write("[{0}]", string.Join(", ", targetarray));
            Console.WriteLine();

            SortedArray = Sorts.Sorter.SelectionSort(targetarray);

            Console.WriteLine("После сортировки выбором: ");
            Console.Write("[{0}]", string.Join(", ", SortedArray));
            Console.WriteLine();

            Console.WriteLine("После сортировки вставкой: ");
            Console.Write("[{0}]", string.Join(", ", Sorts.Sorter.InsertionSort(targetarray)));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
