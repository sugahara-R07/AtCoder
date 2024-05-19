using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _343_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int puls = nums[0] + nums[1];

            for(int i = 0; i< 10; i++)
            {
                if(puls != i)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
