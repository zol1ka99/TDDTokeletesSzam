using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_rendezes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> A = new List<int> { 27, 39, 33, 12, 9, 17 };
            int N = A.Count;
            //i-> ide kerül az aktuális legkisebb
            for (int i = 0; i < N - 1; i = i + 1)
            {
                int min = A[i];
                int index = i;
                // minimum keresés i..n-1
                for (int j = i + 1; j < N; j++)
                {
                    if (A[j] < min)
                    {
                        min = A[j];
                        index = j;
                    }
                }
                //csere
                int temp = A[i];
                A[i] = A[index];
                A[index] = temp;
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i] + ",");
            }
            Console.ReadKey();
        }
    }
}
