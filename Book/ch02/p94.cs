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
            int num 10;
            Console.WriteLine(num);
            Console.WriteLine(num++);
            Console.WriteLine(num--);
            Console.WriteLine(num);
        }
        //10
        //10
        //11
        //10
    }
    static void Main(string[] args)
    {
        int num = 10;
        Console.WriteLine(num);
        Console.WriteLine(++num);
        Console.WriteLine(--num);
        Console.WriteLine(num);
        //10
        //11
        //10
        //10
    }
   
}
