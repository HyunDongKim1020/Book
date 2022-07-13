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
            int[] intarray = { 27, 52, 65, 33, 50 };
            //0번쨰는 0이라고 배열
            intarray[0] = 0;

            Console.WriteLine(intarray[0]);
            Console.WriteLine(intarray[1]);
            Console.WriteLine(intarray[2]);
            Console.WriteLine(intarray[4]);

            int[] intary = { 33, 22, 11, 99, 55 };
            Console.WriteLine(intary.Length);

            




        }

    }
}
