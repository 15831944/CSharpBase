using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 敏感词过滤
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "领导人习大大。~";
            if (Regex.IsMatch(str, @"大方法||df"))
            {
                Console.Write("有敏感词");
                Console.ReadKey();
            }
            else
            {
                Console.Write("没有敏感词");
                Console.ReadKey();
            }

        }
    }
}
