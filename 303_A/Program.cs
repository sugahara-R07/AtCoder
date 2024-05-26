using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _303_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            string T = Console.ReadLine();           

            for(int i = 0; i< N; i++)
            {
                if(!CharCheck(S[i],T[i]))
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }

        public static bool CharCheck(char a,char b)
        {
            if ((a != '1' && a != 'l') && (b != '1' && b != 'l'))
            {
                return true;
            }
            else if ((a != '0' && a != 'o') && (b != '0' && b == 'o'))
            {
                return true;
            }

            if ((a == '1' || a == 'l') && (b == '1' || b == 'l'))
            {
                return true;
            }
            else if((a == '0' || a == 'o') && (b == '0' || b == 'o'))
            {
                return true;
            }

            return false;
        }

       
    }

    
}
