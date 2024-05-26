using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _355_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] AB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int A = AB[0];
            int B = AB[1];

            if(A != B)
            {
                if(A == 1 && B == 2)
                {
                    Console.WriteLine(3);
                }
                else if(A == 1 && B == 3)
                {
                    Console.WriteLine(2);
                }
                else if (A == 2 && B == 3)
                {
                    Console.WriteLine(1);
                }
                else if (A == 2 && B == 1)
                {
                    Console.WriteLine(3);
                }
                else if (A == 3 && B == 1)
                {
                    Console.WriteLine(2);
                }
                else if (A == 3 && B == 2)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
            else
            {
                Console.WriteLine(-1);
            }

            Console.ReadLine();

        }
    }
}
