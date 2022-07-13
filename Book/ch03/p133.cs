using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class p133
    {
        static void Main(string[] args)
        {
            Console.WriteLine("시간을 입력 하세여");
            int Datetime = int.Parse(Console.ReadLine());

            if(8< Datetime &&Datetime <11)
            {
                Console.WriteLine("아침 먹을 시간 입니다");
            }
            if(11<Datetime && Datetime < 18) 
            {
                Console.WriteLine("점심 먹을 시간 입니다");
            }
            else(19<Datetime && Datetime < 24)
            {
                Console.WriteLine("저녁 먹을 시간 입니다");
            }
            }
                
        }
    }
}
