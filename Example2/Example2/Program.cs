using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("나이를 알고 싶은 사람의 이름은 무엇인가요? ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "영준":
                    Console.WriteLine("영준이는 24살입니다.");
                    break;
                case "준혁":
                    Console.WriteLine("준혁이는 29살입니다.");
                    break;
                case "다정":
                    Console.WriteLine("다정이는 영준이와 동갑으로, 24살입니다.");
                    break;
                default:
                    Console.WriteLine("해당 인물의 나이는 알 수 없습니다.");
                    break;
            }


        }
    }
}
