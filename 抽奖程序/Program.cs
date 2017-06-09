using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽奖程序
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rd = new Random();
            int rdNumber = rd.Next(0, 9);
            if (rdNumber / 3 == 0)
            {
                Console.WriteLine("@恭喜您，中奖了！~");
            }
            else
            {
                Console.WriteLine("@很遗憾，您没有中奖。");
            }
            Console.ReadKey();
        }
    }
}

