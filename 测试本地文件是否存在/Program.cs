using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 测试本地文件是否存在
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/lenovo/Desktop/test.jpg";
            
            if (System.IO.File.Exists(path))

            { Console.WriteLine("本地文件确实存在！"); }

            else

            { Console.WriteLine("本地文件不存在！"); }
            Console.ReadKey();

        }
    }
}
