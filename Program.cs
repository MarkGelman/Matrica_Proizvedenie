using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici_Proizvedenie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split();
            int sum = 0;
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
            int d = 0;
            int count = 0;
            int count1 = 0;
            for (int i = 0; count1 < N * K; i++)
            {
                sum = 0;
                count1++;
                if (i > K - 1) { i = 0; d++;}
                for (int j = 0; j < M; j++)
                     sum += mat1[d, j] * mat2[j,i];
                
                if (count != K - 1)
                {
                    Console.Write(sum + " ");
                    count++;
                }
                else
                {
                    Console.WriteLine(sum);
                    count = 0;
                }
                    
            }
        }
    }
}
