using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _355_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NM[0];
            int M = NM[1];

            int[] As = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] Bs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] ans = new int[N+M];

            for (int i = 0; i< N +M; i++)
            {
                if(i<N)
                {
                    ans[i] = As[i];
                }
                else
                {
                    ans[i] = Bs[i-N];
                }
            }
            Array.Sort(ans);

            if(Check(ans,As))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadLine();
        }

        public static bool Check(int[] ans,int[] A)
        {
            for(int i = 0; i< ans.Length; i++)
            {
                for(int j = 0;j< A.Length;j++)
                {
                    if(ans[i] == A[j])
                    {
                        

                        for (int k = 0; k < A.Length; k++)
                        {

                            if (i + 1 >= ans.Length)
                                continue;
                            if (ans[i +1] == A[k])
                            {
                                return true;
                            }
                        }

                    }
                }
            }

            return false;
        }
    }
}
