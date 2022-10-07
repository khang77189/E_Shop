using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thay_Huy_Tuan_3_Entity.Models;

namespace Thay_Huy_Tuan_3_Entity.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Category(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult Brand(String id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult Details(String id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}