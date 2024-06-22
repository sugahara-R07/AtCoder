using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _348_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] points = new int[N,2];

            for(int i = 0; i< N; i++)
            {
                int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                points[i,0] = ints[0];
                points[i,1] = ints[1];
            }



            for(int i = 0;i<N; i++)
            {
                double ans = 0;
                int num = 0;
                for(int j = 0; j<N;j++)
                {
                    if (i == j) continue;
                    // distance = 0;

                    var distance = Math.Sqrt(Math.Pow(points[i, 0] - points[j, 0], 2) + (int)Math.Pow(points[i, 1] - points[j, 1], 2));
                    

                    if(ans < distance)
                    {
                        ans = distance;
                        num = j+1;
                    }
                    
                }
                Console.WriteLine(num);
            }


        }
    }
}
