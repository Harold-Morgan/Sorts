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

                int buff = sortedArray[min];
                sortedArray[min] = sortedArray[i];
                sortedArray[i] = buff;
            }

            return sortedArray;
        }
    }
}
