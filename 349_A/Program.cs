using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _349_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int ans = 0;

            for(int i = 0; i< nums.Length; i++)
            {
                ans += nums[i];
            }

            Console.WriteLine(ans * -1);

            Console.ReadLine();
            

        }
    }
}
