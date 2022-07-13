using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch04
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int i= 0;
            for (int a = 0; a < 100; a++)
            {
                i += a;
            }
            Console.WriteLine("i");
            //1~100까지의 덧셈

            int j = 1;
            for (int b = 0; b <= 20; b++)
            {
                j = j * b;
            }
            Console.WriteLine(j);
            //1~20까지의 곱셈

            for (int c = '가'; c <= '힣';c++)
            {
                Console.WriteLine((char)c);
            }
            
        }

    }
}
