using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _347_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NK[0];
            int K = NK[1];
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> ans = new List<int>();
            for(int i = 0;i<N; i++)
            {
                if (nums[i] % K == 0)
                {
                    ans.Add(nums[i] /K);
                }
            }

            for(int i = 0; i< ans.Count; i++)
            {
                Console.Write(ans[i]);
                if(i != ans.Count - 1)
                {
                    Console.Write(' ');
                }
            }

            Console.ReadLine();
        }
    }
}
