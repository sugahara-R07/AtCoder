using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _354_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = int.Parse(Console.ReadLine());
            double height = 0;
            int count = 0;

            height += 1;
            count++;
            while (true)
            {
                height = (height *2 ) + 1;
                count++;
                if(H<height)
                {
                    break;
                }

                
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
