using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Thay_Huy_Tuan_3_Entity.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BlogSingle(String id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}