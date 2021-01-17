using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    class Program
    {

        //8.
        //Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul
        //al doilea devine penultimul etc
        //1 2 3 4 5
        //5 4 3 2 1

        static int[] rotireStanga(int[] v)
    {
        int[] v2 = new int[v.Length];
        int j = v.Length - 1;
        for (int i = 0; i < v.Length && j >= v.Length / 2; i++)
        {
            v2[j] = v[i];
            v2[i] = v[j];
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

        int[] v2 = rotireStanga(v);

        for (int i = 0; i < v2.Length; i++)
        {
            Console.Write(v2[i] + " ");
        }
    }
   }

}