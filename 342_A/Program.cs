using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _342_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            int count = 0;
            string X = S[0].ToString();

            if (X != S[1].ToString())
            {
                if(X != S[2].ToString())
                {
                    X = S[1].ToString();
                }
                else
                {
                    X = S[0].ToString();
                }
            }


            for(int i = 0; i< S.Length;i++)
            {
                if(X != S[i].ToString())
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }

            Console.ReadLine();

            

        }
    }
}
