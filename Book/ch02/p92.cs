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
            string output = "hello;
            output += "world";
            output += "!";

            Console.WriteLine(output);
            //hello world
        }
        static void Main(string[] args)
        {
            string ouput = "hello";
            ouput = ouput + "world";
            ouput = ouput + "!";

            Console.WriteLine(ouput);
        }
    }
}
