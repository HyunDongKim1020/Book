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
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour); // 3보다 작고 8보다 크다
            Console.WriteLine(3 < DateTime.Now.Hour $$ DateTime.Now.Hour < 8); // 3보다 크고 8보다 작다
            

        }
    }
}
