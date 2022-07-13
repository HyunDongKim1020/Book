using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.ch03
{
    internal class _138p
    {
        static void Main(string[] args)
        {
            Console.WriteLine("이번달은 몇 월인가요?");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울 입니다");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름 입니다);
                        break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("겨울 입니다");
                    break;
                default:
                    Console.WriteLine("어디서 사나요?");
                    break;
            }   
        }
    }
}
