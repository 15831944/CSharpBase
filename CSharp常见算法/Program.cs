using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp常见算法
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "I am a good man";
            foreach (var item in s1.Reverse())
            {
                Console.Write(item);
            }
            Console.WriteLine();
            string[] str = s1.Split(' ');
            foreach (var item in str.Reverse())
            {
                Console.Write(item+' ');
            }

            Console.ReadKey();
        }

    }
}
