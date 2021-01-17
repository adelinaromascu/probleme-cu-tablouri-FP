using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    class Program
    {
        //problema 7
        //Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelge ca primul element devine ultimul,
        //al doilea devine penultimul, etc.
        //1 2 3 4 5 6
        //6 5 4 3 2 1
        static int[] inverse(int[] v)
        {
            int[] v2 = new int[v.Length];
            int j = v2.Length - 1;
            for (int i = 0; i < v.Length; i++)
            {
                v2[j] = v[i];
                j--;
            }
            return v2;
        }

        static void Main(String[] args)
        {
            int[] v = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();

            int[] v2 = inverse(v);

            for (int i = 0; i < v2.Length; i++)
            {
               Console.Write(v2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
