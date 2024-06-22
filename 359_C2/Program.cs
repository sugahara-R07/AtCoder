using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _359_C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] S = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] T = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long y = (S[1] - T[1])* (- 1);
            if(y<0)
            {
                y = y * (-1);
            }

            long x = (S[0] - T[0]) * (-1);

            bool check = false;
            if (x < 0)
            {
                x = x * (-1);
                check = true;
            }

            long puls = 0;

            if(S[0] % 2 == 1)
            {
                if (S[0] > T[0])
                {
                    puls++;
                }
               
            }
            else
            {
                if (S[0] < T[0])
                {
                    puls++;
                }
            }

            if(y >= x+puls)
            {
                Console.WriteLine(y);
                return;
            }


            if(y < x + puls)
            {
                if (S[0] > T[0])
                {
                    if(check)
                    {
                        Console.WriteLine(y + ((x - y) / 2) +1);
                    }
                    else
                    {
                        Console.WriteLine(y + ((x - y) / 2));
                    }
                   
                    
                    return;

                }
                else
                {
                    long a = S[0] - T[0];
                    a = a * -1;
                    if (S[0] % 2 == 1 && a < 2)
                    {
                        
                        if (check)
                        {
                            Console.WriteLine(y + ((x - y) / 2));
                        }
                        else
                        {
                            Console.WriteLine(y + ((x - y) / 2) +1 );
                        }
                    }
                    else
                    {
                        if (check)
                        {
                            Console.WriteLine(y + ((x - y) / 2) +1);
                        }
                        else
                        {
                            Console.WriteLine(y + ((x - y) / 2));
                        }
                        
                    }
                    
                    return;

                }
            }

            




        }
    }
}
