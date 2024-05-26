using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _335_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            for(int i = 0; i<S.Length-1;i++)
            {
                Console.Write(S[i]);
            }

            Console.WriteLine("4");
        }
    }
}
