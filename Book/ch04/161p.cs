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
            //원하는 크기의 배열 공간 생성
            int[] intarray = new int[100];

            //요소의 길이 출력
            Console.WriteLine(intarray[0]);
            Console.WriteLine(intarray[99]);
        }
    }
}
