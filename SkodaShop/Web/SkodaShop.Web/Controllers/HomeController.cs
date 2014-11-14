namespace SkodaShop.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using SkodaShop.Data.Models;
    using SkodaShop.Data;

    public class HomeController : Controller
    {
        private IRepository<Part> parts;

        public HomeController()
            : this(new GenericRepository<Part>(new ApplicationDbContext()))
        {
        }

        public HomeController(IRepository<Part> parts)
        {
            this.parts = parts;
        }

        public ActionResult Index()
        {
            var parts = this.parts.All();

            return View(parts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}