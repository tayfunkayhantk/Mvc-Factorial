using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Faktöriyel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int number = 0)
        {

            int conclusion = 1;


            for (int i = 1; i <= number; i++)
            {
                conclusion = conclusion * i;
            }


            ViewBag.conc = conclusion;
            return View();
        }


    }
}