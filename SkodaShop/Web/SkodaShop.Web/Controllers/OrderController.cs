namespace SkodaShop.Web.Controllers
{
    using SkodaShop.Data.Common.Repository;
    using SkodaShop.Data.Models;
    using System.Web.Mvc;

    public class OrderController : Controller
    {
        private IRepository<Part> parts;

        public OrderController(IRepository<Part> parts)
        {
            this.parts = parts;
        }

        public ActionResult Index()
        {
            var parts = this.parts.All();

            return this.View(parts);
        }
    }
}