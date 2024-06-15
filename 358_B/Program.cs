using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _358_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NA = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NA[0];
            int A = NA[1];
            int[] T = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int second = T[0];
            second += A;
            Console.WriteLine(second);
            for (int i = 1; i< N; i++)
            {
                if(second >= T[i])
                {
                    second += A;
                    Console.WriteLine(second);
                }
                else
                {
                    second++;
                    i--;
                    continue;
                }
            }

            //Console.WriteLine(second);
            Console.ReadLine();

        }
    }
}
