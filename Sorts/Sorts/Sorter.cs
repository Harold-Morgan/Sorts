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

            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = i; (j > 0 && sortedArray[j] < sortedArray[j - 1]); j--)
                    Helper.Swap(ref sortedArray, j, j - 1);
            }

            return sortedArray;
        }

        /// <summary>
        /// Сортировка Шелла
        /// </summary>
        /// <param name="targetarray"></param>
        /// <returns></returns>
        public static int[] ShellSort(int[] targetarray)
        {
            int[] sortedArray = (int[])targetarray.Clone();

            int h = 1;

            while (h < sortedArray.Length)
                h = 3 * h + 1; //Последовательность Кнута
            while (h >= 1)
            {
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    for (int j = i; (j > 0 && sortedArray[j] < sortedArray[j - 1]); j--)
                        Helper.Swap(ref sortedArray, j, j - 1);
                }

                h = h / 3;
            }

            return sortedArray;
        }
    }

    static class quicksorter
    {
        static int partition(int[] array, int start, int end)
        {
            int marker = start;//первый элемент, стандартный квиксорт
            for (int i = start; i <= end; i++)
            {
                if (array[i] < array[end]) 
                {
                    Helper.Swap(ref array, marker, i);
                    marker += 1;
                }
            }
            //ставим пивот
            Helper.Swap(ref array, marker, end);

            return marker;
        }

        public static int[] quicksort(int[] array, int start, int end)
        {
            if (start >= end)
            {
                return array;
            }
            int pivot = partition(array, start, end);
            quicksort(array, start, pivot - 1);
            quicksort(array, pivot + 1, end);

            return array;
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
