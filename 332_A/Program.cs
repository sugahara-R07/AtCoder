using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _332_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] NSK = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] nums = new int[NSK[0], 2];
            

            int money = 0;

            for(int i = 0;i < NSK[0];i++)
            {
                int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                money += a[0] * a[1];
            }

            if(money < NSK[1])
            {
                money += NSK[2];
            }

            Console.WriteLine(money);
            Console.ReadLine();

        }
    }
}
