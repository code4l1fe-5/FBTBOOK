using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopWeb.Models;

namespace ShopWeb.Controllers
{
    public class TrangChuController : Controller
    {
        private ShopWebDbContext db = new ShopWebDbContext();
        // GET: TrangChu
        public ActionResult Index()
        {
            ViewBag.SoMauTin = db.Products.Count();
            return View();
        }
    }
}