using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    class Program
    {
        //Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
        //Se cere sa se insereze valoarea e in vector pe pozitia k.Primul element al vectorului se considera pe pozitia zero. 
        //1 2 3 4 5 6 // poz = 1; e= 7
        //1 2 3 7 4 5 6 
        
        //functie care adauga elementul 
        static int[] insert(int[] v, int poz,int e)
        {   //cream un vector de aceeasi lungime + 1 cu vectorul initial
            int[] v2 = new int[v.Length + 1];
            
            for(int i = 0; i <= poz; i++)
            {
                v2[i] = v[i];
            }
            //copiem la pozitia k elementul dat.
            v2[poz] = e;

            for(int i = v2.Length-1; i > poz; i--)
            {
                v2[i] = v[i-1];
            }

            return v2;
            
        }
        static void Main(string[] args)
        {// a nu se testa cu valori mai mari decat 0 si v.length, nu s-a implementat sistem de prevenire a acestei erori.
            int[] v = { 1, 2, 3, 4, 5, 6 };
            int e = 7;
            int poz = 1;

           for(int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Noul vector cu elementul inserat: ");
           
            int[] v2 = insert(v, poz, e);

            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write(v2[i] + " ");
            }

        }
    }
}
