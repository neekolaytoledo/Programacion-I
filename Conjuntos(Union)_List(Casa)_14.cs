using System;
using System.Collections.Generic;
using System.Text;

namespace Conjuntos_List_Casa__14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 0, 3, 6, 6, 6, 9, 15, 12, 12, 12, 18, 18 };
            int[] B = { 0, 0, 2, 2, 4, 6, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };
            //double temp = 0;
            //double temp2 = 0;

            List<int> union = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                union.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)
            {
                union.Add(B[i]);
            }

            union.Sort();
            for (int i = 0; i < union.Count - 1; i++)
            {
                if (union[i] == union[i + 1])
                {
                    union.RemoveAt(i);
                    i = 0;
                }
            }

            for (int i = 0; i < union.Count; i++)
            {
                Console.Write(union[i] + ",");
            }
            Console.WriteLine();
        }

       
    }
   
}
