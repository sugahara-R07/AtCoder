using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _357_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //入力
            int N = int.Parse(Console.ReadLine());

            //各Nの値の時の結果　N＝1～6
            string[,] masu1 = new string[int.Parse(Math.Pow(3, 1).ToString()), int.Parse(Math.Pow(3, 1).ToString())];
            string[,] masu2 = new string[int.Parse(Math.Pow(3, 2).ToString()), int.Parse(Math.Pow(3, 2).ToString())];
            string[,] masu3 = new string[int.Parse(Math.Pow(3, 3).ToString()), int.Parse(Math.Pow(3, 3).ToString())];
            string[,] masu4 = new string[int.Parse(Math.Pow(3, 4).ToString()), int.Parse(Math.Pow(3, 4).ToString())];
            string[,] masu5 = new string[int.Parse(Math.Pow(3, 5).ToString()), int.Parse(Math.Pow(3, 5).ToString())];
            string[,] masu6 = new string[int.Parse(Math.Pow(3, 6).ToString()), int.Parse(Math.Pow(3, 6).ToString())];

            //N＝0
            if (N == 0)
            {
                Console.WriteLine("#");
                return;
            }

            //N＝1
            for (int i = 0; i < Math.Pow(3,1); i++)
            {
                for (int j = 0; j < Math.Pow(3, 1); j++)
                {
                    if(j % 3 == 1 && i % 3 ==1)
                    {
                        masu1[j,i] = ".";
                    }
                    else
                    {
                        masu1[j, i] = "#";
                    }

                    //最後に真ん中を空ける処理
                    if((j > Math.Pow(3,N-1)-1 && j < Math.Pow(3, N-1)*2) && (i > Math.Pow(3, N - 1) - 1 && i < Math.Pow(3, N - 1) * 2))
                    {
                        masu1[j, i] = ".";
                    }

                }
            }
            if(N == 1)
            {
                OutPut(N, masu1);
                return;
            }

            //N＝2
            masu2 = MasuCreat(2, masu1, masu2);
            if(N == 2)
            {
                OutPut(N,masu2);
                return;
            }
            //N＝3
            masu3 = MasuCreat(3, masu2, masu3);
            if (N == 3)
            {
                OutPut(N, masu3);
                return;
            }
            //N＝4
            masu4 = MasuCreat(4, masu3, masu4);
            if (N == 4)
            {
                OutPut(N, masu4);
                return;
            }
            //N＝5
            masu5 = MasuCreat(5, masu4, masu5);
            if (N == 5)
            {
                OutPut(N, masu5);
                return;
            }
            //N＝6
            masu6 = MasuCreat(6, masu5, masu6);
            if (N == 6)
            {
                OutPut(N, masu6);
                return;
            }
           
        }

        public static void OutPut(int N ,string[,] masu)
        {
            for (int i = 0; i < Math.Pow(3, N); i++)
            {
                for (int j = 0; j < Math.Pow(3, N); j++)
                {
                    Console.Write(masu[j, i]);

                }
                Console.WriteLine();
            }
        }

        public static string[,] MasuCreat(int N,string[,] masu, string[,] masu2)
        {
           
            for (int i = 0; i < Math.Pow(3, N); i++)
            {
                for (int j = 0; j < Math.Pow(3, N); j++)
                {
                    int j2 = (int)j % (int)Math.Pow(3, N-1);
                    int i2 = (int)i % (int)Math.Pow(3, N - 1);
                    masu2[j, i] = masu[j2, i2];

                    //最後に真ん中を空ける処理
                    if ((j > Math.Pow(3, N - 1) - 1 && j < Math.Pow(3, N - 1) * 2) && (i > Math.Pow(3, N - 1) - 1 && i < Math.Pow(3, N - 1) * 2))
                    {
                        masu2[j, i] = ".";
                    }
                }
            }
            return masu2;
        }
    }
}
