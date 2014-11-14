namespace SkodaShop.Web.Controllers
{
    using SkodaShop.Web.Models;
    using System.Web.Mvc;
    using System.Web.Http;

    public class PartController : Controller
    {
        // GET: Part
        public ActionResult Index()
        {
            return View();
        }        

        //[HttpGet]
        //public IHttpActionResult GetAll()
        //{
        //    var student = this.data
        //         .Students
        //         .All()
        //         .Select(PartViewModel.FromPart);

        //    return Ok(student);
        //}
    }
}