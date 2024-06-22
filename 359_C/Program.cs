using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _359_C
{
    internal class Program
    {

        class Vecter2
        {
            long x; long y;

            long okane = 0;
            public Vecter2(long x ,long y)
            {
                this.x = x;
                this.y = y;
            }

            public long X
            {
                get { return x; }
                set 
                {
                    if((X % 2 == 0) && (value == X-1))
                    {
                        okane++;
                    }
                    else if ((X % 2 == 1) && (value == X + 1))
                    {
                        okane++;
                    }
                    x = value; 
                }
            }

            public long Y
            {
                get { return y; }
                set
                {
                    okane++;
                    y = value;
                }
            }

            public void Ans()
            {
                Console.WriteLine(okane -1);
            }


        }
        static void Main(string[] args)
        {
            long[] S = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] T = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            bool right = false;
            bool left = false;
            bool onazi = false;

            bool up = false;
            bool down = false;
            bool heikou = false;

            if(S[0] > T[0])
            {
                left = true;
            }
            else if(S[0] < T[0])
            {
                right = true;
            }
            else
            {
                onazi = true;
            }


            if (S[1] < T[1])
            {
                up = true;
            }
            else if (S[1] > T[1])
            {
                down = true;
            }
            else
            {
                heikou = true;
            }

            Vecter2 start = new Vecter2(S[0], S[1]);
            Vecter2 goal = new Vecter2(T[0], T[1]);


            while (true)
            {
                if (start.X % 2 == 0 && start.Y != goal.Y)
                {
                    if (up)
                    {
                        start.Y = start.Y + 1;
                    }
                    else if (down)
                    {
                        start.Y = start.Y - 1;
                    }
                    else
                    {
                        if (right)
                        {
                            start.X = start.X + 1;
                        }
                        else
                        {
                            start.X = start.X - 1;
                        }
                    }
                }
                else if(start.X != goal.X)
                {
                    if (right)
                    {
                        start.X = start.X + 1;
                    }
                    else if (left)
                    {
                        start.X = start.X - 1;
                    }
                    else
                    {
                        if (up)
                        {
                            start.Y = start.Y + 1;
                        }
                        else if (down)
                        {
                            start.Y = start.Y - 1;
                        }
                    }
                }

                if (goal.X == start.X && goal.Y == start.Y)
                {
                    start.Ans();
                    break;
                }
            }
        }
    }
}
