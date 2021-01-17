using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class Program
    {
        //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. 
        //Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
     
        //functie care returneaza cel mai mic element din tablou
        static int min(int[] v)
        {   int min = v[0];
            for(int i = 0; i < v.Length; i++)
            {
                if(v[i] <= min)
                {
                    min = i;
                }
            }
              return min;
        }

        static int max(int[] v)
        {   int max = v[0];
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > max)
                {
                    max = i;
                }
            }
          return max;
        }

        static void Main(string[] args)
        {
            int[] v = {1, 2, 3, 4, 5 };

            Console.WriteLine("Pozitia minimului: " + min(v));
            Console.WriteLine("Pozitia maximului: " + max(v));


        }
    }
}
