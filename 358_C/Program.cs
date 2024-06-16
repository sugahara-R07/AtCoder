using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _358_C
{
    internal class Program
    {
        public class Popcorn
        {
            public int shops;
            public bool flag = true;
            public int num = 0;

            public int pool = 0;
            string str = "";

            public Popcorn(int shops, int[] S, int M)
            {
                this.shops = shops;
                pool = shops;
                

                for (int i = 0; i < S.Length; i++)
                {
                   
                    if (IsOn(shops, i+1))
                    {
                        this.shops = this.shops | S[i];
                        num++;
                    }
                    
                }

                for(int i = 0; i< M;i++)
                {
                    str += "1";
                }

                for(int i = 0;i<M;i++)
                {
                    if (!IsOn(this.shops, i + 1))
                    {
                        flag = false;
                    }
                }

                if(flag)
                {
                    Console.WriteLine(str);
                }

            }

            public bool GetFlag()
            { return flag; }
            public int GetNum()
            {
                return num;



            }
        }

        static void Main(string[] args)
        {

            int[] NM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NM[0];
            int M = NM[1];

            int[] S = new int[N];

            for (int i = 0; i < N; i++)
            {
                S[i] = Convert.ToInt32(Console.ReadLine().Replace('o', '1').Replace('x', '0'), 2);
            }

            string strN = "";

            for (int i = 0; i < N; i++)
            {
                strN += "1";
            }


            List<Popcorn> list = new List<Popcorn>();

            Int32 strBit = 0;

            for (int i = 0; i <= Convert.ToInt32(strN, 2); i++)
            {
                strBit++;
                Popcorn popcorn = new Popcorn(strBit, S, M);
                list.Add(popcorn);
            }

            List<int> ans = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].GetFlag())
                {
                    ans.Add(list[i].GetNum());
                }
                    
            }

            ans.Sort();

            Console.WriteLine(ans[0]);
            Console.ReadLine();

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
