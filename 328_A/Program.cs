using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _328_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NX = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NX[0];
            int X = NX[1];

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int ans = 0;
            for(int i = 0; i<N;i++)
            {
                if (nums[i] <= X)
                {
                    ans += nums[i];
                }
            }

            Console.WriteLine(ans);
        }
    }
}
