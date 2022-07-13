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
            Console.WriteLine(!true);      //faluse
            Console.WriteLine(!false);      //true
            Console.WriteLine(!(52 < 273));     //falise
            Console.WriteLine(!(52 > 273));     //true
        }
    }
}
