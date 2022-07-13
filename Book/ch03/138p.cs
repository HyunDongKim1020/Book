using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class _138p
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력 하세여");
            int intput = int.Parse(Console.ReadLine());

            switch(intput % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다");
                    break;
                case 1:
                    Console.WriteLine("홀수 입니다");
                    break;
            }
              
        }
    }
}
