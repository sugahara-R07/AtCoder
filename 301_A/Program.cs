using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            int[,] count = new int[2, 2];

            for (int i = 0; i < N; i++)
            {
                if (S[i] == 'T')
                {
                    count[0, 0]++;
                    count[0, 1] = i;
                }
                else
                {
                    count[1, 0]++;
                    count[1, 1] = i;
                }
            }

            if (count[0, 0] > count[1, 0])
            {
                Console.WriteLine('T');
                return;
            }
            else if (count[0, 0] == count[1, 0])
            {
                if (count[0, 1] < count[1, 1])
                {
                    Console.WriteLine('T');
                    return;
                }

            }
            Console.WriteLine('A');

        }
    }
}
