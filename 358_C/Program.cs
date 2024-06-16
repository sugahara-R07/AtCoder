using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _358_C
{
    internal class Program
    {
        public class Popcorn
        {
            public uint shops = 0;
            public bool flag = true;
            public int num = 0;

            public Popcorn(uint shops, int[] S, int M,int N)
            {
                for (int i = 0; i < S.Length; i++)
                {             
                    if (IsOn((int)shops, i+1))
                    {
                        this.shops = this.shops | (uint)S[i];                  
                    }           
                }

                for(int i = 0; i < M; i++)
                {
                    if (!IsOn((int)this.shops, i + 1))
                    {                  
                        flag = false;
                    }
                }

                for(int i = 0;i<N;i++)
                {
                    if (IsOn((int)shops, i + 1))
                    {
                        num++;
                    }
                }
            }

            public bool GetFlag()
            { return flag; }
            public int GetNum()
            { return num; }
        }

        static void Main(string[] args)
        {
            //フィールド
            int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NM[0];
            int M = NM[1];

            int[] S = new int[N];
            string strN = "";//ビットの最大保存用

            Int32 strBit = 0;//ビット全探索用のカウント
            int ansNum = 999999999;//最低回数保存用(最初は最大数)

            //計算
            for (int i = 0; i < N; i++)
            {
                S[i] = Convert.ToInt32(Console.ReadLine().Replace('o', '1').Replace('x', '0'), 2);
                strN += "1";
            }

            for (int i = 0; i <= Convert.ToInt32(strN, 2); i++)
            {
                strBit++;
                Popcorn popcorn = new Popcorn((uint)strBit, S, M,N);
                if (popcorn.GetFlag())
                {
                    if (ansNum > popcorn.GetNum())
                        ansNum = popcorn.GetNum();
                }
            }

            //回答
            Console.WriteLine(ansNum);
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
