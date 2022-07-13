using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int a = 2147483640;
            int b = 52273;

            Console.WriteLine(a + b);
            //-2147431383
            //int형의 자료형의 범위를 넘어섰기 때문에 -2147431383이 된것이다
        }
    }
}
