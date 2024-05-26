using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _334
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] BG = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if(BG[0] > BG[1])
            {
                Console.WriteLine("Bat");
            }
            else
            {
                Console.WriteLine("Glove");
            }
        }
    }
}
