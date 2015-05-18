using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// Project based on Tutsplus.com lesson: 
// https://code.tutsplus.com/courses/aspnet-at-your-service-web-api/lessons/creating-a-web-api-project

namespace WebService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
