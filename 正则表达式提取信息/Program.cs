using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 正则表达式提取信息
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
           var data= wc.DownloadData("http://www.dianping.com/beijing/ch50/g157");
            string pageHtml = Encoding.UTF8.GetString(data);
            Console.WriteLine(pageHtml);
        }
    }
}
