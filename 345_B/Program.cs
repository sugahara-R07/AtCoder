using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _345_B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long X = long.Parse(Console.ReadLine());


            if(X % 10 == 0)
            {
                long ans = X / 10;
                Console.WriteLine(ans);
            }
            else
            {
                long ans = X / 10;
                if(ans > 0)
                    ans = ans + 1;

                Console.WriteLine(ans);
            }

            Console.ReadLine();
        }
    }
}
