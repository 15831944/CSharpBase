using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 测试网络文件是否存在
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"https://wkbdemo.blob.core.chinacloudapi.cn/classicons/9838/t_f025c35e-a5c3-4013-8005-593e4e9d9.png";//网络文件地址
            if (JudgeFileExist(url))
            { Console.WriteLine("03网络文件确实存在！"); }
            else
            { Console.WriteLine("03网络文件不存在！"); }
            Console.ReadKey();
        }
        private static bool JudgeFileExist(string url)
        {
            try
            {
                //创建根据网络地址的请求对象
                System.Net.HttpWebRequest httpWebRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.CreateDefault(new Uri(url));
                httpWebRequest.Method = "HEAD";
                httpWebRequest.Timeout = 1000;
                //返回响应状态是否是成功比较的布尔值
                return (((System.Net.HttpWebResponse)httpWebRequest.GetResponse()).StatusCode == System.Net.HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
        }
    }
}
