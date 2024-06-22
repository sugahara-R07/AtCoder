using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _359_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int N = int.Parse(Console.ReadLine());
            string[] StrN = new string[N];

            for(int i = 0; i<N;i++)
            {
                StrN[i] = Console.ReadLine();
            }

            int count = 0;

            for (int i = 0; i < StrN.Length; i++)
            {
                if (StrN[i] == "Takahashi")
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
