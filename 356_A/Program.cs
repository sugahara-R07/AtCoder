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

            int[] nums = new int[NLR[0]];

            int N = NLR[0];
            int L = NLR[1];
            int R = NLR[2];
            int pool = 0;

            //Rの法が大きい用に修正
            if(R < L)
            {
                pool = R;
                R = L;
                L = pool;
            }

            //配列を格納
            for(int i = 0; i< N; i++ )
            {
                nums[i] = i + 1;
            }

            int j = R -1;
            int i1 = L - 1;

            int num = (R - L +1)/2;

            for (int x = 0; x<num  ;x++)
            {
                pool = nums[i1];
                nums[i1] = nums[j];
                nums[j] = pool;

                j--;
                i1++;
            }


            for(int i = 0;i<N;i++)
            {
                Console.Write(nums[i]);

                if(i != N-1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine( );
                }
            }
            Console.ReadLine();
        }
    }
}
