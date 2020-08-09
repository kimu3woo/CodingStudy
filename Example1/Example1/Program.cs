using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("값을 입력해주세요: ");
            string str = Console.ReadLine();
            float a;
            a = float.Parse(str);
            Console.Write("값을 입력해주세요: ");
            str = Console.ReadLine();
            float b;
            b = float.Parse(str);
            float result = a * b;
            Console.WriteLine((int)result);
        }
    }
}
