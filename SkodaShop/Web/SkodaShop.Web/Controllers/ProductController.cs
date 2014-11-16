namespace SkodaShop.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using SkodaShop.Data.Models;
    using SkodaShop.Data;
    using SkodaShop.Data.Common.Repository;

    public class ProductController : Controller
    {
        private IRepository<Part> parts;

        public ProductController(IRepository<Part> parts)
        {
            this.parts = parts;
        }

        public ActionResult Index()
        {
            var parts = this.parts.All();

            return View(parts);
        }
    }
}