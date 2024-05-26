using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _355_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NT = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = NT[0];//N×Nのビンゴ
            int T = NT[1];//ターン
            int counter = 0;//ターンの保存
            int[] hit = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] ans = new int[N, N];//ビンゴの空いた穴保存


            //Tターンのループ
            do
            {
                //出た数からビンゴの位置を特定
                int i = 0;
                int j = 0;
                if(hit[counter] % N == 0)
                {
                    i = hit[counter] / N - 1;
                    j = N - 1;
                }
                else
                {
                    i = hit[counter] / N;
                    j = (hit[counter] % N) - 1;
                }

                //ビンゴの穴を空ける
                ans[i, j] = 1;

                //穴の数がN以下なら次のループへ
                if (counter < N-1)
                {
                    counter++;
                    continue;
                }

                //穴が空いた場所の縦、横 + 斜め一列が空いている状態か確認
                if (Check(ans, N, i, j))
                {
                    Console.WriteLine(counter + 1);
                    return;
                }

                //ターンを進める
                counter++;

            }while(counter<T);//ターンの間繰り返す

            //ターン内に見つからない場合-1を出力
            Console.WriteLine(-1);
        }

        public static bool Check(int[,] ans, int N,int gyou, int retu)
        {
            //各列のチェックフラグ
            bool bingo = true;//縦
            bool bingo2 = true;//横
            bool bingo3 = true;//斜め
            bool bingo4 = true;//斜め

            for (int i = 0; i<N; i++)
            {
                //すべての列で空いていない項目があれば確認終了
                if(!bingo && !bingo2 && !bingo3 && !bingo4)
                    return false;

                if (ans[gyou,i] != 1)
                    bingo = false;
                if (ans[i, retu] != 1)
                    bingo2 = false;
                if (ans[i, i] != 1)
                    bingo3 = false;
                if (ans[i, N - 1 - i] != 1)
                    bingo4 = false;
            }

            //ビンゴならTrueを返す
            if (bingo)
                return true;
            if (bingo2)
                return true;
            if (bingo3)
                return true;
            if (bingo4)
                return true;

            //どの判定にも引っかからなければFalseを返す
            return false;
        }
    }
}
