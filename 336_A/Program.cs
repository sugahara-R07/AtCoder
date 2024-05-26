using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _336_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string ans ="L";

            for(int i = 0; i< N; i++)
            {
                ans += "o";
            }

            ans += "ng";

            Console.WriteLine(ans);
        }
    }
}
