using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfTicher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split();
            int N = int.Parse(s1[0]);
            int M = int.Parse(s1[1]);
            int[,] mat1 = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                string[] str1 = Console.ReadLine().Split();
                for (int j = 0; j < M; j++)
                    mat1[i, j] = int.Parse(str1[j]);
            }
            string[] s2 = Console.ReadLine().Split();
            int K = int.Parse(s2[1]);
            int[,] mat2 = new int[M, K];
            for (int i = 0; i < M; i++)
            {
                string[] str2 = Console.ReadLine().Split();
                for (int j = 0; j < K; j++)
                    mat2[i, j] = int.Parse(str2[j]);
            }
            Console.WriteLine();

            int[,] mat3 = new int[N, K];
            for (int i=0; i<N; i++)
            {
                for (int j=0; j<K; j++)
                {
                    mat3[i, j] = 0;
                    for (int k=0; k<M; k++)
                    {
                        mat3[i,j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    Console.Write(mat3[i, j]);
                    if (j != K - 1) Console.Write(" ");
                    else Console.WriteLine();

                }
            }
    }
}
