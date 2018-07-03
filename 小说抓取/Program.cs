using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace 小说抓取
{
    class Program
    {
        static void Main(string[] args)
        {

            //HttpWebRequest MyHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.amazon.com/gp/offer-listing/B004PLY1EG");
            //MyHttpWebRequest.Timeout = 1000 * 60 * 10 * 10;
            //MyHttpWebRequest.Proxy = null;
            //MyHttpWebRequest.Method = "GET";
            //MyHttpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            //MyHttpWebRequest.Headers.Add("Accept-Language", "zh-cn,zh;q=0.8,en-us;q=0.5,en;q=0.3");
            //MyHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 5.2; rv:12.0) Gecko/20100101 Firefox/12.0";
            //HttpWebResponse httpWebResponse = (HttpWebResponse)MyHttpWebRequest.GetResponse();
            var wc = new WebClient
            {
                Encoding = Encoding.UTF8,
                Proxy = null
            };
            wc.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            //var html = wc.DownloadString("http://www.biqusa.com/3_3580/18958757.html");
            string htmlcontent = "";
            var html = wc.DownloadString("https://www.23wxw.cc/html/62721/");
            //var regex = new Regex(@"<h1 name=""keywords"".+content=""(.+)"".+/>");
            //var regex = new Regex(@"<h1>(.+)</h1>");

            //var regex = new Regex(@"<div class=""box_con"">(.|\n)*?</div>");
            var regex = new Regex(@"<dt>《不爱江山爱美人》正文</dt>(.|\n)*?<dt><b>喜欢这本书的人还喜欢</b></dt>");
            var regexContent = new Regex(@"<div id=""content"" deep=""3"">(.|\n)*?<div align=""center"">");
            if (regex.IsMatch(html))
            {
                // var title = regex.Match(html).Groups[1].Value;
                //var mat = regex.Match(html);
                //string content = mat.Groups[0].ToString().Replace(@"<div id=""content"">", "").Replace("</div>", "").Replace("&nbsp;", "").Replace("<br />", "\r\n");
                string content = regex.Match(html).Groups[0].ToString();
                Regex tmpreg = new Regex("<a[^>]+?href=\"([^\"]+)\"[^>]*>([^<]+)</a>", RegexOptions.Compiled);
                MatchCollection sMC = tmpreg.Matches(content);
                //foreach (var item in sMC)
                //{
                //      Console.Write(item.grou);
                //}
                try
                {
                    for (int i = 458; i < sMC.Count; i++)
                    {
                        Thread.Sleep(10000);
                        Console.WriteLine($"{i + 1}--{sMC[i].Groups[2].Value}");
                        Console.WriteLine($"{i + 1}--{sMC[i].Groups[1].Value}");
                        htmlcontent = wc.DownloadString($"https://www.23wxw.cc/{sMC[i].Groups[1].Value}");
                        var mat = regexContent.Match(htmlcontent);
                        string contentReplace = mat.Groups[0].ToString().Replace(@"<div id=""content"" deep=""3"">", "").Replace("</div>", "").Replace("&nbsp;", "").Replace("<br/>", "\r\n").Replace(@"<div align=""center"">", "");
                        string path = AppDomain.CurrentDomain.BaseDirectory.Replace("\\", "/") + "Txt/";
                        Novel(sMC[i].Groups[2].Value + "\r\n" + contentReplace, "不爱江山爱美人", path); Console.WriteLine($"第{i + 1}章{sMC[i].Groups[2].Value}写入成功");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }


            }

            Console.Read();
        }
        /// <summary>
        /// 创建文本
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="name">名字</param>
        /// <param name="path">路径</param>
        private static void Novel(string content, string name, string path)
        {
            string Log = content + "\r\n";
            //创建文件夹，如果不存在就创建file文件夹
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            //判断文件是否存在，不存在则创建
            if (!System.IO.File.Exists(path + name + ".txt"))
            {
                FileStream fs1 = new FileStream(path + name + ".txt", FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(Log);//开始写入值
                sw.Close();
                fs1.Close();
            }
            else
            {
                FileStream fs = new FileStream(path + name + ".txt" + "", FileMode.Append, FileAccess.Write);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(Log);//开始写入值
                sr.Close();
                fs.Close();
            }
        }
    }
}
