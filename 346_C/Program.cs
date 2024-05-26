using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _346_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] NK = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long N = NK[0];
            long K = NK[1];

            long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long ans = 0;
            for(int i = 0;i<K;i++)
            {
                ans += i +1;
            }

            long pool = 0;
            long plus = 0;

            Array.Sort(nums);
            for(int i = 0;i<N;i++)
            {
                if (nums[i] <= K && nums[i] != pool)
                {
                    plus += nums[i];
                    pool = nums[i];
                }
            }

            ans = ans - plus;

            Console.WriteLine(ans);



        }
    }
}
