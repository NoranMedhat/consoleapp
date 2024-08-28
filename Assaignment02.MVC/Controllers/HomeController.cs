using Microsoft.AspNetCore.Mvc;

namespace Assaignment02.MVC.Controllers
{
    public class HomeController : Controller
    {
        #region MyRegion
        //public ActionResult Index()
        //{

        //    return Content("Hello From Index");
        //}

        //public ActionResult AboutUs()
        //{
        //    return Redirect("https://drive.google.com/drive/folders/18B9-kvGFWuqql0Ai_iRunjecAYvr4F-G");
        //} 
        #endregion

        public IActionResult Index() { return View(); }
        public IActionResult AboutUs() { return View(); }
        public IActionResult Contact() { return View(); }
        public IActionResult Privacy() { return View(); }
    }
}
