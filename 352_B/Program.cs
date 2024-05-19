using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _352_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();

            int nums = 0;
            List<int> ans = new List<int>();
            for(int i = 0; i < T.Length; i++)
            {
                if (S[nums] == T[i])
                {
                    nums++;
                    ans.Add(i + 1);
                    continue;
                }
                if(nums >= S.Length)
                {
                    break;
                }
                
            }

            for(int i = 0; i< ans.Count; i++)
            {
                Console.Write(ans[i]);
                if(i != ans.Count -1)
                {
                    Console.Write(" ");
                }
            }

            Console.ReadLine();
        }
    }
}
