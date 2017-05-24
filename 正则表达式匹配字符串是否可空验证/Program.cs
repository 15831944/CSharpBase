using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 正则表达式匹配字符串是否可空验证
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string phone = null;
                var regex = new System.Text.RegularExpressions.Regex(@"^1\d{10}$");
                bool result = regex.IsMatch(phone);
                Console.WriteLine(result);
                Console.ReadKey();
         

        }
    }
}
