using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace 序列化字符串是否包含某字符串
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            string str = "{ \"errcode\":41001,\"errmsg\":\"access_token missing hint: [eyDbQa0604vr57!]\"}";
            var data = new { errcode = 0, errmsg = "" };
            data = JsonConvert.DeserializeAnonymousType(str, data);
            if (data.errcode==0)
            {
                Console.WriteLine("成功");
            }
            else
            {
                Console.WriteLine("失败");
            }
            Console.ReadKey();
        }
    }
}
