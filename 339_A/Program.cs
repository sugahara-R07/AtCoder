using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _339_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int count = 0;
            int count2 = 0;

            for (int i = 0; i < S.Length; i++) 
            {
                if (S[i] == '.')
                {
                    count++;
                }
            }

            for (int i = 0; i < S.Length;i++)
            {
                if(S[i] == '.' && count2 < count)
                {
                    count2++;
                    continue;
                }

                if(count == count2)
                {
                    Console.Write(S[i]);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
