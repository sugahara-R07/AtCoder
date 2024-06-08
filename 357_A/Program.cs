using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _357_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NM[0];
            int M = NM[1];

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int ans = 0;

            for(int i = 0; i<N;i++)
            {
                if(ans + nums[i] <= M)
                {
                    ans += nums[i];
                }
                else
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            if (M == 0)
            {
                Console.WriteLine(0);
                return;
            }
                
            Console.WriteLine(N);

        }
    }
}
