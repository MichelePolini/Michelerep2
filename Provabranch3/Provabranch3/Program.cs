using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provabranch3
{
    class Program
    {
            public static int max(int[] v)
        {
            int a = 0;
            for (int i = 0; i < 11; i++)
            {
                if (v[i] > a)
                {
                    a = v[i];
                }

            }
            return a;
        }

        public static int min(int[] v)
        {
            int a = 999999;
            for (int i = 0; i < 11; i++)
            {
                if (v[i] < a)
                {
                    a = v[i];
                }

            }
            return a;
        }
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

            int risultato_max = max(array);
            int risultato_min = min(array);
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            Console.ReadLine();

        }
    }
}
   