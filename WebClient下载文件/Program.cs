using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WebClient下载文件
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string URLAddress = "";
            string receivePath = @"E:\gcd\";
            for (int i = 1; i < 51; i++)
            {
                if (i < 10)
                {
                    URLAddress = $@"http://kiohhb.520tingshu.com/鬼吹灯/南海归墟0{i}.mp3";
                }
                else
                {
                    URLAddress = $@"http://kiohhb.520tingshu.com/鬼吹灯/南海归墟{i}.mp3";
                }
                Console.WriteLine($"开始下载-{Path.GetFileName(URLAddress)}");
                client.DownloadFile(URLAddress, receivePath + Path.GetFileName(URLAddress));
                Console.WriteLine($"{Path.GetFileName(URLAddress)}-下载完毕");
            }
            Console.ReadKey();
        }
    }
}
