using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _337_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] nums = new int[N,2];
            int T = 0;
            int Y = 0;            
            for(int i = 0; i< N; i++)
            {
                int[] inNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                nums[i,0] = inNum[0];
                nums[i,1] = inNum[1];

                T += inNum[0];
                Y += inNum[1];
            }

            if(T > Y)
            {
                Console.WriteLine("Takahashi");
            }
            else if(T == Y)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine("Aoki");
            }



        }
    }
}
