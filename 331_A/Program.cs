using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _331_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MD = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int M = MD[0];
            int D = MD[1];

            int[] ymd = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int y = ymd[0];
            int m = ymd[1];
            int d = ymd[2];

            if(d +1 > D)
            {
                if( m +1 > M )
                {
                    Console.WriteLine(y + 1 + " " + "1 1");
                }
                else
                {
                    int m2 = m + 1;
                    Console.WriteLine(y + " " + m2+ " 1");
                }
            }
            else
            {
                int d2 = d + 1;
                Console.WriteLine(y + " " + m + " " + d2);
            }

            Console.ReadLine();
        }
    }
}
