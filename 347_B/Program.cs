using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _347_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            List<string> ans = new List<string>();

            for(int i = 0; i< S.Length;i++)
            {
                string pool = S[i].ToString();
                ans.Add(pool);
                for(int j = i+1; j< S.Length;j++)
                {
                    pool += S[j];
                    ans.Add(pool);
                }
            }
            // 重複した要素を削除
            var result = ans.Distinct();
            Console.WriteLine(result.Count());
            Console.ReadLine();
            //Console.WriteLine(string.Join(", ", result));


        }
    }
}
