using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult Index1()
        {
            int Empno = int.Parse(Request.QueryString["E"]);
           EMPDATA E=DBOperations.Empdata(Empno);
            ViewBag.msg = "1 row inserted";
                return View("Index",E);
        }
    }
}