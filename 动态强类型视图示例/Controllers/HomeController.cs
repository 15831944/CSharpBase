using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 动态强类型视图示例.Controllers
{
    public class HomeController : Controller
    {
        public class Blogs {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
        // GET: Home
        public ActionResult Index()
        {
            List<Blogs> list = new List<Blogs> {
                new Blogs { Id=1,Name="蒋金楠的Blogs",Description="讲的很不错"}
            };
            return View(list);
        }
    }
}