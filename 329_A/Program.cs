using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _329_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            for (int i = 0; i < S.Length; i++)
            {
                Console.Write(S[i]);

                if (i < S.Length - 1)
                    Console.Write(" ");
                else
                    Console.WriteLine();
            }
        }
    }
}
