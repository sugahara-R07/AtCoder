using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string[] arr = new string[] {
                 "M", "L", "K", "J", "I","H", "G", "F", "E", "D","C","B","A" ,
            };
            Int32 strBit = 0;
            List<string> ans = new List<string>();

            string N = "";

            for (int i = 0; i < arr.Length; i++)
            {
                N += "1";
            }

            for (int i = 0; i <= Convert.ToInt32(N, 2); i++)
            {
                num++;
                strBit++;
                string s = "";
                var bit = strBit;

                for (int j = 1; j <= arr.Length; j++)
                {
                    if (IsOn(bit, j))
                    {
                        s += arr[arr.Length - j];
                    }
                }

                ans.Add(s);
            }

            ans.Sort();

            for (int i = 0; i < ans.Count; i++)
            {
                Console.WriteLine(ans[i]);
            }
            Console.WriteLine(num);

            Console.ReadLine();

            //for (int i = 0; i <N ; i++)
            //{
            //    S[i] = Convert.ToInt32(Console.ReadLine().Replace('o', '0').Replace('x', '1'), 2);

            //}
        }

        public static bool IsOn(int data, int digit)
        {
            // チェックしたいビットを1桁目に右シフトする
            // (例) 1101 の3桁目をチェックしたい場合、2ビット右シフト 1101 → 0011
            int x = data >> (digit - 1);

            // 1とのAND演算をして1ビット目だけを 1 or 0 の状態にする
            // (例) 0011 & 0001 -> 0001
            int y = x & 1;

            // 結果が1か0かを判定
            bool isOn = y == 1;

            return isOn;
        }
    }
}
