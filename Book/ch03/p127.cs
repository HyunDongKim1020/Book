using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간 입니다.");
            }
            else if (Date.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간 입니다");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간 입니다");
            }
        }
    }
}
