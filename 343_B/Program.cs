using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _343_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] nums = new int[N,N];
            List<List<int>> anser = new List<List<int>>();

            for (int i = 0; i<N; i++)
            {
                int[] inNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for(int j = 0; j < N; j++)
                {
                    nums[j,i] = inNum[j];

                }
            }

            for(int i = 0; i<N; i++)
            {
                anser.Add(new List<int>());
                for(int j = 0; j<N; j++)
                {
                    if(nums[j,i] == 1)
                    {
                        anser[i].Add(j +1);
                    }
                }
            }

            for(int i = 0; i<N;i++)
            {
                Console.WriteLine(string.Join(" ", anser[i]));
            }
        }
    }
}
