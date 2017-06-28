using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 时间字符串转DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeString = "2017-08-09";
            DateTime dt = DateTime.Parse(timeString);
            Console.WriteLine(dt.ToShortDateString()); 
        }
    }
}
