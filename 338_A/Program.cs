using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _338_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            if(!char.IsUpper(S[0]))
            {
                Console.WriteLine("No");
                return;
            }

            for(int i = 1; i< S.Length; i++)
            {
                if (char.IsUpper(S[i]))
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
