using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
        //1 1 2 3 4 5
        //1 2 3 4 5 5 

        static void Main(string[] args)
        {
            int[] v = { 1, 1, 2, 1, 3, 4, 5, 5, 7, 7, 8 };

            int min = v[0], frecvMin = 0;
            int max = v[0], frecvMax = 0;

            for (int i = 0; i < v.Length; i++)
            {

                if (min == v[i])
                {
                    frecvMin++;
                }
                else if (min < v[i])
                {
                    min = v[i];
                    frecvMin = 1;
                }

                if (max == v[i])
                {
                    frecvMax++;
                }
            }

         Console.WriteLine("Frecventa maximului: " + min + " este: " + frecvMin);
         Console.WriteLine("Frecventa minimului: " + max + " este: " + frecvMax);


        }
    }
}
