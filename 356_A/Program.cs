using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _356_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NLR = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NLR[0];
            int L = NLR[1];
            int R = NLR[2];

            int[] nums = new int[N];

            for(int i = 0; i<N;i++)
            {
                nums[i] = i+1;
            }

            bool fl = false;

            int T = Math.Abs(R-L)/2;

            int num = L - R;

            if(num<0)
            {
                
                for (int i = 0; i < T; i++)
                {
                    int pool = nums[R - 1 - i];
                    nums[R - 1 - i] = nums[L - 1 + i];
                    nums[L - 1 + i] = pool;
                    fl = true;
                }

                if (T == 0 && !fl)
                {
                    int pool = nums[R - 1];
                    nums[R - 1] = nums[L - 1];
                    nums[L - 1] = pool;
                }
            }
            
            else
            {
                for (int i = 0; i < T; i++)
                {
                    int pool = nums[R - 1 + i];
                    nums[R - 1 + i] = nums[L - 1 - i];
                    nums[L - 1 - i] = pool;
                }

                if (T == 0 && !fl)
                {
                    int pool = nums[R - 1];
                    nums[R - 1] = nums[L - 1];
                    nums[L - 1] = pool;
                }
            }
            

            

            for(int i = 0; i<N;i++)
            {
                Console.Write(nums[i]);
                if(i<N-1)
                {
                    Console.Write(" ");
                }
            }

            Console.ReadLine();
            

        }
    }
}
