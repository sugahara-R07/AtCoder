using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _352_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = nums[0];
            int X = nums[1];
            int Y = nums[2];
            int Z = nums[3];

            if(X<Z && Z< Y)
            {
                Console.WriteLine("Yes");
            }
            else if(Y<Z && Z<X)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadLine();
        }
    }
}
