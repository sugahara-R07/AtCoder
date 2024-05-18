using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _354_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int reated = 0;
            int mod;

            string[] s = new string[N];

            for (int i = 0; i < N; i++)
            {
                string[] array = Console.ReadLine().Split().ToArray();
                s[i] = array[0];
                reated += int.Parse(array[1]);
            }

            Array.Sort(s);
            mod = reated % N;

            Console.WriteLine(s[mod]);
            Console.ReadLine();
        }

        public struct Book
        {
            public string s, nums;
            public Book(string s, string nums)
            {
                this.s = s;
                this.nums = nums;
            }
            public string GetString()
            {
                return s;
            }

            public int GetNums()
            {
                return int.Parse(nums);
            }
        }

        public static bool Check(string s1,string s2)
        {
            string[] ss = {s1,s2};
            Array.Sort(ss);
            if(ss[0]== s1)
            {
                return true;
            }

            return false;
        }


    }
}
