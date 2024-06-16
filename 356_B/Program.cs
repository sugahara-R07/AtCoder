using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _356_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NM[0];
            int M = NM[1];
            int[] A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] X = new int[N,M];

            int[] count = new int[M];
                
            for(int i = 0; i< N; i++)
            {
                int[] X1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int j = 0; j<X1.Length;j++)
                {
                    X[i,j] = X1[j];

                    count[j] += X1[j];
                }
            }

            for(int i = 0; i<M;i++)
            {
                if (A[i] > count[i])
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");

        }
    }
}
