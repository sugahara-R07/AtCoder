using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _358_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NM[0];
            int M = NM[0];

            string[] S = new string[N];

            for (int i = 0;i<N;i++)
            {
                S[i] = Console.ReadLine();
            }

            char[] ansM = new char[M];


            
        }
    }
}
