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
            int output = 0;
            output += 52;
            output += 273;
            output += 103;

            Console.WriteLine(output);
            //428
        }
    }
    static void Main(string[] args)
    {
        int output = 0;
        output = output + 52;
        output = output + 273;
        output = output + 103;

        Console.WriteLine(output);
        //428
        //위에거 쉽게 요약한 버전
    }
}
