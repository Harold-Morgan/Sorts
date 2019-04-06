using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts.Sorts
{
    //TODO: было бы прикольно зафигачить все по паттерну, но пока и так пойдёт
    static class Sorter
    {
        /// <summary>
        /// Сортировка выбором
        /// </summary>
        /// <param name="targetarray">Массив, который нужно отсортировать</param>
        /// <returns>Отсортированный массив</returns>
        public static int[] SelectionSort(int[] targetarray)
        {
            int[] sortedArray = (int[])targetarray.Clone();

            for (int i = 0; i < sortedArray.Length; i++)
            {
                int min = i;
                for (int j = min + 1; j < sortedArray.Length; j++)
                    if (sortedArray[j] < sortedArray[min])
                    {
                        min = j;
                    }

                Helper.Swap(ref sortedArray, min, i);
               /* int buff = sortedArray[min];
                sortedArray[min] = sortedArray[i];
                sortedArray[i] = buff; */
            }

            return sortedArray;
        }

        /// <summary>
        /// Сортировка вставкой
        /// </summary>
        /// <param name="targetarray"></param>
        /// <returns></returns>
        public static int[] InsertionSort(int[] targetarray)
        {
            int[] sortedArray = (int[])targetarray.Clone();
            bool haveWeMet;

            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = i; (j > 0); j--)
                    if (sortedArray[j] < sortedArray[j-1])
                    {
                        Helper.Swap(ref sortedArray, j, j - 1);
                    }
            }

            return sortedArray;
        }

    }

    static class Helper
    {
        public static void Swap (ref int[] array, int a, int b)
        {
            int buff = array[a];
            array[a] = array[b];
            array[b] = buff;

            //return array;
        }
    }
}
