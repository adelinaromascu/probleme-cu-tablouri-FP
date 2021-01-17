using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    class Program
    {
        //9.Rotire k.
        //Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga
        //1 2 3 4 5
        //k=1
        // p nr de pozitii pana la v[k]
        // t = k -p ->  ca sa stii cat sa scazi din v.length
        static int[] rotireStangaK(int[] v, int k)
        {
            int n = v.Length;
            int[] v2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                v2[(i + n - k) % n] = v[i];
            }
            return v2;
        }
        static void Main(String[] args)
        {
            int[] v = { 1, 2, 3, 4, 5 };
            int k = 2;
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
               Console.WriteLine();

            int[] v2 = rotireStangaK(v, k);

            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write(v2[i] + " ");
            }
        }

    }
}
