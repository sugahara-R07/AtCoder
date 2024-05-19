using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _345_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string S2 = "";
            int count = 0;
            for(int i = 0; i< S.Length; i++)
            {
                string a = S[S.Length - i - 1].ToString();
                if (a == ">")
                {
                    count++;
                    a = "<";
                }
                    
                else if (a == "<")
                {
                    count++;
                    a = ">";
                }
                    
                S2 += a;
            }

            if(count % 2 != 0 || count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            
            if(S == S2)
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }
            Console.ReadLine();
        }
    }
}
