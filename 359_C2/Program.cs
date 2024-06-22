using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _359_C2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //18,19,20のテストケースが抜けない
            long[] S = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] T = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();




            long y = (S[1] - T[1]) * (-1);
            if (y < 0)
            {
                y = y * (-1);
            }

            long x = (S[0] - T[0]) * (-1);


            if (x < 0)
            {
                x = x * (-1);
            }



            if (y > x + 1)
            {
                Console.WriteLine(y);
                return;
            }

            long ans = y + ((x - y) / 2);

            if (T[0] % 2 == 0 && (S[1] * -1) % 2 == 1)
            {
                ans++;
            }


            Console.WriteLine(ans);
            return;

        }


    }
}
