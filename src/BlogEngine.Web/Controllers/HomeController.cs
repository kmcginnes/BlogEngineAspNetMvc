using System;
using System.Web.Mvc;

namespace BlogEngine.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StartBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StartBlog(StartBlogModel model)
        {
            return View(model);
        }
    }

    public class StartBlogModel
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Tagline { get; set; }
        public DateTime StartDate { get; set; }
    }
}
