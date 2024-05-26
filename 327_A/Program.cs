using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _327_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            for(int i = 0; i< S.Length-1;i++)
            {
                if (S[i] == 'a' )
                {
                    if(S[i +1 ] == 'b')
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
                else if(S[i] == 'b')
                {
                    if (S[i + 1] == 'a')
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }

            Console.WriteLine("No");

        }
    }
}
