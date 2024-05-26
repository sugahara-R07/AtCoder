using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _349_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();
            int counter = 0;

            T = T.ToLower();
            for(int i = 0;i<S.Length;i++)
            {
                if (T[counter] == S[i])
                {
                    counter++;
                }

                if(counter == 2)
                {
                    if (T[2] == 'x')
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }

                if(counter == 3)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            Console.WriteLine("No");
        }
    }
}
