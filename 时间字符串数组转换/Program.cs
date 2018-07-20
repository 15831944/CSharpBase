using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 时间字符串数组转换
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] times = { "2017-08-04","2015-06-06","2013-02-01"};
            var len = times.Length;
            DateTime[] dateTimes = new DateTime[3];
            foreach (var item in times.ToList())
            {
                   dateTimes.SetValue(Convert.ToDateTime(item),times.ToList().IndexOf(item));     
            }
            foreach (var item in dateTimes)
            {
               Console.WriteLine(item); 
            }
           
        }
    }
}
