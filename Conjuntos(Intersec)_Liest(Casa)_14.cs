using System;
using System.Collections.Generic;
using System.Text;

namespace Conjuntos_Intersec__Liest_Casa__14
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] A = { 0, 0, 3, 6, 6, 6, 9, 15, 12, 12, 12, 18, 18 };
            int[] B = { 0, 0, 2, 2, 6, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };
            List<int> intersec = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                intersec.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)
            {
                intersec.Add(B[i]);
            }
            

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        Console.Write(intersec[i] + ",");
                        /*for (int k = 0; k < intersec.Count - 1; k++)
                        {
                            if (intersec[k] == intersec[k + 1])
                            {
                                intersec.RemoveAt(k);
                                k = 0;
                            }
                        }*/
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
