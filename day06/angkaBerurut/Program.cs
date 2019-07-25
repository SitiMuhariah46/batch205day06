using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angkaBerurut
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tampung = Console.ReadLine().Split(' ');

            int[] arrayTampung = new int[tampung.Length];

            arrayTampung = Array.ConvertAll(tampung, int.Parse);

            for (int i = tampung.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arrayTampung[j] > arrayTampung[j + 1])
                    {
                        int temp = arrayTampung[j];
                        arrayTampung[j] = arrayTampung[j + 1];
                        arrayTampung[j + 1] = temp;
                    }
                }
            }
            for (int ii = 0; ii < tampung.Length; ii++)
                Console.Write(arrayTampung[ii] + " ");

            Console.ReadLine();

        }
    }
}
