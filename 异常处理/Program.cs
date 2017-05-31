using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 异常处理
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5 };
            try
            {
                test();
                Console.WriteLine(number[9]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }



            Console.ReadKey();
        }
        public static void test()
        {
            throw new WException("发生了错误");
        }

    }
    public class WException : Exception
    {
        public WException(string message) : base(message) { }
    }
}
