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
            int i = 0;
            int[] intarry = { 456, 159, 156, 335, 753 };

            while(i < intarry.Length)
            {
                Console.WriteLine(i + "번째 출력:" intarry[i]);

                i++;
            }
        }
    }
}
