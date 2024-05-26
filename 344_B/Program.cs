using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _344_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inNum = new List<int>();

            for(int i = 0; i< 100;i++)
            {
                try
                {
                    string s = Console.ReadLine();

                    if (s != "")
                    {
                        inNum.Add(int.Parse(s));
                    }
                }
                catch
                {
                    break;
                }
            }

            for(int i = 0; i<inNum.Count; i++)
            {
                Console.WriteLine(inNum[inNum.Count - i -1]);
            }
            Console.ReadLine();
        }
    }
}
