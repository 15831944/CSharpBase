using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace 判断XML中是否存在某个节点
{
    class Program
    {
        static void Main(string[] args)
        {
            string _xml = @"<xml>
<AppId>第三方平台appid</AppId>
<CreateTime>1413192760</CreateTime>
<InfoType>unauthorized</InfoType>
<AuthorizerAppid>公众号appid</AuthorizerAppid>
</xml>";
            XmlDocument doc = new XmlDocument();
            XmlNode root;
            XmlNodeList xnl;
            doc.LoadXml(_xml);
            xnl= doc.GetElementsByTagName("InfoType");
            if (xnl.Count!=0)
            {
                Console.WriteLine("存在该节点。");
            }
            else
            {
                Console.WriteLine("不存在该节点。");
            }
        }
    }
}
