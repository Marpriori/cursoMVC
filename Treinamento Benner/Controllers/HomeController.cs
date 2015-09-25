using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treinamento_Benner.Filters;

namespace Treinamento_Benner.Controllers
{
    [LogActionFilter]
    public class HomeController : Controller
    {
        // GET: /Home/
        public ActionResult Index()
        {
            DateTime data = DateTime.Now;
            return View(data);
        }

        //GET: /Home/Browse?genre=Disco
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode(
                "Home.Browse, Genre = " + genre);
            return message;
        }
        //GET: /Home/Details/5
        public string Details(int id)
        {
            string message = HttpUtility.HtmlEncode(
                "Home.Details, ID = " + id);
            return message;
        }

        public ViewResult Action()
        {
            ViewBag.Message = "Hello!";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public RedirectToRouteResult Redirect()
        {
            return RedirectToAction("Action", "Home");
        }

    }
}
