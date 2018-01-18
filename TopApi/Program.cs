using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;

namespace TopApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sessionkey = "6101f03c14614cea6de7b2c0611deb0b57f8d7d136bc85f327294445";
            string appkey = "********";
            string AppSecret = "************************************";
            string url = "http://gw.api.taobao.com/router/rest";
            ITopClient client = new DefaultTopClient(url, appkey, AppSecret,"JSON");
            TbkItemGetRequest req = new TbkItemGetRequest();
            req.Fields = "num_iid,title,pict_url,small_images,reserve_price,zk_final_price,user_type,provcity,item_url,seller_id,volume,nick";
            req.Q = "女装";
            req.Cat = "16,18";
            req.Itemloc = "杭州";
            req.Sort = "tk_rate_des";
            req.IsTmall = false;
            req.IsOverseas = false;
            req.Platform = 1L;
            req.PageNo = 123L;
            req.PageSize = 20L;
            TbkItemGetResponse rsp = client.Execute(req);
            Console.WriteLine(rsp.Body);
            Console.ReadKey();
        }
    }
}
