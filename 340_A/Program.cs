using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _340_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int A = nums[0];
            int B = nums[1];
            int D = nums[2];

            int num = A;
            List<int> ans = new List<int>();

            ans.Add(num);

            while (true)
            {
                if (num + D <= B)
                {
                    num += D;
                    ans.Add(num);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", ans));
            Console.ReadLine();
        }
    }
}
