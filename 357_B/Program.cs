using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _357_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int oomozi = 0;
            int komozi = 0;

            for(int i = 0; i< S.Length; i++)
            {
                if(char.IsUpper(S[i]))
                {
                    oomozi++;
                }
                else
                {
                    komozi++;
                }
            }

            if(oomozi > komozi)
            {
                Console.WriteLine(S.ToUpper());
            }
            else
            {
                Console.WriteLine(S.ToLower());
            }
        }
    }
}
