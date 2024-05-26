using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _302_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] AB = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long A = AB[0];
            long B = AB[1];

            long C = A / B;
            long D = A % B;

            if (AB[0] % AB[1] == 0) Console.WriteLine(C);
            else Console.WriteLine(C + 1);
            Console.ReadLine();
        }
    }
}
