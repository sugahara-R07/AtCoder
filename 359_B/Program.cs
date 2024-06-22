using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _359_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;

            for(int i = 0; i< nums.Length-2;i++)
            {
                if(nums[i] == nums[i+2])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            


        }
    }
}
