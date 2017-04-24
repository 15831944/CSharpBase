using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 判断bool值
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] orgIds = { 16775, 17158 };
            bool isXuJing = false;
            foreach (var item in orgIds)
            {
                if (16775 == item)
                {
                    isXuJing = false;
                }
                break;
            }
            Console.WriteLine(isXuJing.ToString());
            Console.ReadKey();
        }
    }
}
