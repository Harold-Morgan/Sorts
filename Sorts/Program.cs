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
            int[] targetarray = new int[1000];
            Random randNum = new Random();

            for (int i = 0; i < targetarray.Length; i++)
                targetarray[i] = randNum.Next(0, 1000);


            Console.Write("[{0}]", string.Join(", ", targetarray));


            Console.ReadKey();
        }
    }
}
