using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch02
{
    internal class Class1
    {
        svm static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);
        }
        /*
         * 10
         * 12
         * 12
         * 10
         */
    }
    static void Main(string[] args)
    {
        int number1 = 10;

        Console.WriteLine(number1); //10
        number1++;     //11
        number1++;     //12
        Console.WriteLine(number1); //12
        Console.WriteLine(number1); //12
        number1--;    //11
        number1--;    //10
        Console.WriteLine(number1); //10

    }
}
