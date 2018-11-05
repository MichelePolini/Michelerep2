using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provabranch3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[11];

            array[0] = 1;
            array[1] = 3;
            array[2] = 56;
            array[3] = 234;
            array[4] = 236;
            array[5] = 245;
            array[6] = 240;
            array[7] = 294;
            array[8] = 2134;
            array[9] = 3000;
            array[10] = 32;
            Console.WriteLine("Il valore massimo dell'array e': "+array.Max());
            Console.WriteLine("Il valore minimo dell'array e': "+array.Min());
            Array.Sort(array);
            Console.Write("Array ordinato in modo crescente: " + "");
            for (int i = 0; i < 11; i++)
            {
                Console.Write(array[i].ToString()+" ");

            }
            Console.ReadLine();

        }
    }
}
   