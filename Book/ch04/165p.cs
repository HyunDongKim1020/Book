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
            string input;
            do
            {
                Console.Write("입력(exit을 입력하면 종려)");
                input = Console.ReadLine();
            } while (input != "exit");

        }
    }
}
