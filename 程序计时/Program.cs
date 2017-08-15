using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 程序计时
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            ////List<A> list;
            ////list = new List<A>();
            ////A a = new A();
            ////for (int i = 0; i < 10000000; i++)
            ////{
            ////    a.Id = 1;
            ////    a.Name = "小花";
            ////    list.Add(a);
            ////}
            //List<A> a = new List<A>();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    a.Add(new A() { Id = 1, Name = "小花" });
            //}
            //string str=   stopwatch.Elapsed.TotalSeconds.ToString(CultureInfo.InvariantCulture);
            //Console.WriteLine(str);
            var rand = new Random();
            var result = rand.Next(600000000);
            Console.WriteLine(result);

        }
    }

    class A
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
