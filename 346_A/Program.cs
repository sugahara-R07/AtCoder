using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _346_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<int> ans = new List<int>();

            for(int i = 0; i< N-1; i++)
            {
                ans.Add(nums[i] * nums[i+1]);
            }

            Console.WriteLine(string.Join(" ", ans));
            
        }
    }
}
