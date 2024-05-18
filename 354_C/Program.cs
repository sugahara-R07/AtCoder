using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _354_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[,] nums = new string[N, 2];
            int reated = 0;
            int mod;

            string[] s = new string[N];
                
            for (int i = 0; i < N; i++)
            {
                string[] array = Console.ReadLine().Split().ToArray();
                s[i] = array[0];
                reated += int.Parse(array[1]);
            }

            Array.Sort(s); 
            mod = reated % N;

            Console.WriteLine(s[mod]);
            Console.ReadLine();
        }
    }
}
