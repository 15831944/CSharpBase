using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 可空类型
{
    class Program
    {
        static void Main(string[] args)
        {
            int? a = 5;
            int? b = null;
            Console.WriteLine("a:HasValue={0},Value={1}",a.HasValue,a.Value);
            Console.WriteLine("b:HasValue={0},Value={1}", b.HasValue, b.GetValueOrDefault());
            Console.ReadKey();
        }
    }
}
