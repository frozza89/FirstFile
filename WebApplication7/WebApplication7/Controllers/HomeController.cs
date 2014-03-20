using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Search search)
        {
            if ()
            {
                return ViewBag.Error = "Nada encontrado";
            }
            else
            {
                return View("SearchPage",search);
            }
        }

	}
}