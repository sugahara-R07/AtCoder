using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _349_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            List<Char> list = new List<Char>();
            foreach (char c in S)
            {
                list.Add(c);
            }
            if(list.Count == 1)
            {
                Console.WriteLine("No");
                return;
            }
                


            list.Sort();
            int a = 1;

            List<int> ans = new List<int>();

            for (int i = 0; i < list.Count -1; i++)
            {
                if (list[i] != list[i + 1])
                {
                    ans.Add(a);
                    a = 1;
                }
                else
                {
                    a++;
                }

                if (i == list.Count - 2)
                {
                    ans.Add(a);
                }
            }

            ans.Sort();

            int num = ans[0];
            int count = 0;
            for(int i = 0; i< ans.Count; i++)
            {
                foreach(var n in ans) 
                {
                    if(n == ans[i])
                        count++;
                }

                if (count > 2 || count == 1 )
                {
                    Console.WriteLine("No");
                    return;
                }

                count = 0;
            }

            Console.WriteLine("Yes");

            Console.ReadLine();

        }


    }
}
