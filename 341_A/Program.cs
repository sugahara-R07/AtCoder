using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _341_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N  =  int.Parse(Console.ReadLine());
            string ans = "";

            for(int i = 0; i< N; i++)
            {
                ans += "10";
            }

            Console.WriteLine(ans +"1");
            Console.ReadLine();

        }
    }
}
