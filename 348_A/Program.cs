
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _348_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int ans = 0;

            for (int i = 1; i <= N; i++)
            {
                if (i % 3 != 0)
                {
                    Console.Write("o");
                }
                else
                {
                    Console.Write("x");
                }
            }

            Console.WriteLine();
        }
    }
}
