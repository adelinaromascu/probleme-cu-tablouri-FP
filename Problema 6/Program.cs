using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    class Program
    {
        //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. 
        //Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
       
        //1 2 3 4 
        //k = 1
        //1 2 4  
        
 
    static int[] stergeElement(int[] v, int k)
        {
            int[] v2 = new int[v.Length - 1];
            int j = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (i != k)
                {
                    v2[j] = v[i];
                    j++;
                }

            }

            return v2;
        }


        static void Main(String[] args)
        {
            int[] v = { 1, 2, 3, 4 };
            int k = 2;
            for (int i = 0; i < v.Length; i++)
            {
               Console.Write(v[i] + " ");
            }
            Console.WriteLine();

            int[] v2 = stergeElement(v, k);
            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write(v2[i] + " ");
            }

        }
    }
}
