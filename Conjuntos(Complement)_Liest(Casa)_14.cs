using System;
using System.Collections.Generic;
using System.Text;

namespace Conjuntos_List_Casa__14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] U = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] A = { 0, 0, 3, 6, 6, 6, 9, 15, 12, 12, 12, 18, 18 };
            int[] B = { 0, 0, 2, 2, 6, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };
            List<int> Complemnt = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                Complemnt.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)
            {
                Complemnt.Add(B[i]);
            }
            for (int i = 0; i < U.Length; i++)
            {
                Complemnt.Add(U[i]);
            }


            Complemnt.Sort();
            for (int i = 0; i < Complemnt.Count - 1; i++)
            {
                if (Complemnt[i] == Complemnt[i + 1])
                {
                    Complemnt.RemoveAt(i);
                    i = 0;
                }
                
            }
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < U.Length; j++)
                {
                    if (A[i] == U[j])
                    {
                        Complemnt.RemoveAt(i);
                        i = 0;
                    }
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == U[j])
                    {
                        Complemnt.RemoveAt(i);
                        i = 0;
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



            for (int i = 0; i < Complemnt.Count; i++)
            {
                Console.Write(Complemnt[i] + ",");
            }
            Console.WriteLine();


        }
    }
}
