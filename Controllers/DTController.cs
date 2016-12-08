using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final4125.Controllers
{
    public class DTController : Controller
    {
        // GET: DT
        public ActionResult Index()
        {
            return View();
        }

        public string Today()
        {
            return   "time right now " +  HttpUtility.HtmlEncode(@DateTime.Now.Year) ;
        }
    }
}