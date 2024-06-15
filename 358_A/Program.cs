using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _358_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ST = Console.ReadLine().Split(' ').ToArray();

            if(ST[0] != "AtCoder")
            {
                Console.WriteLine("No");
                return;
            }

            if (ST[1] != "Land")
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine("Yes");
        }
    }
}
