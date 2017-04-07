using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台程序测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int sum = 0;
            #region 即将测试的代码段
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 10000000; j++)
                {
                    sum += j;
                }
            } 
            #endregion
            watch.Stop();
            string time = watch.ElapsedMilliseconds.ToString();
            Console.WriteLine(time);
            Console.ReadKey();
        }
    }
}
