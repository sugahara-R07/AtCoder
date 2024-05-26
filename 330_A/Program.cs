using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _330_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NL = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 0;
            for(int i = 0; i< NL[0]; i++)
            {
                if (nums[i]>= NL[1])
                    counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
