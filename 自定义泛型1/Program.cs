using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义泛型1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list[0].GetType();
            Console.WriteLine(list[0].GetType());
            Console.ReadKey();

        }
    }
}
