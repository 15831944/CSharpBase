using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64Encode
{
    class Program
    {
        static void Main(string[] args)
        {
          string str=  EncodeBase64(Encoding.UTF8, "我爱你中国");
            Console.WriteLine(str);
        }
        public static string EncodeBase64(Encoding encode, string source)
        {
            string enString = "";
            byte[] bytes = encode.GetBytes(source);
            try
            {
                enString = Convert.ToBase64String(bytes);
            }
            catch
            {
                enString = source;
            }
            return enString;
        }
    }
}
