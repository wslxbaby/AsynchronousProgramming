using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asynchronous.Service;

namespace Asynchronous.MVC.Custom.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            AsyncMethod at = new AsyncMethod();
            
            return View();
        }

    }
}
