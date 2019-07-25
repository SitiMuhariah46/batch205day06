using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurufBerurut
{
    class Program
    {
        static void Main(string[] args)
        {
            string tampung = Console.ReadLine().ToLower();

            char[] kata = new char[tampung.Length];
            kata = tampung.ToCharArray();

                   
                   //Console.WriteLine(kata);

                   for (int i = 0; i <tampung.Length; i++)
                   {
                       for (int j = 0; j < i; j++)
                       {
                           if (kata[i] < kata[j])
                           {
                               char temp = kata[i];
                               kata[i] = kata[j];
                               kata[j] = temp;                              
                           }
                       }
                   }

                   for (int k = 0; k < tampung.Length; k++)
                   {
                       Console.Write(kata[k]);  
                   }
                            
                   Console.ReadLine();
        }
    }
}
