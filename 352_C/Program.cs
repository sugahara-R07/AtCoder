using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _352_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] AB = new int[N,2];
            int[] max = { 0, 0 };
            int[] min = { 0, 0 };

            for(int i = 0; i< N; i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                AB[i,0] = nums[0];
                AB[i,1] = nums[1];

                if(max[0] < (nums[1]- nums[0]))
                {
                    max[0] = nums[1] - nums[0];
                    max[1] = i;
                }
                else if(min[0] < (nums[1]))
                {
                    min[0] = nums[1];
                    min[1] = i;
                }           
            }

            long ans = AB[min[1], 0] + AB[max[1],1];


            for (int i = 0; i < N; i++)
            {
                if (i == max[1] || i == min[1])
                    continue;

                ans += AB[i,0];
            }

            if(max[1] == min[1])
            {
                ans -= AB[0, 0];
            }

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
