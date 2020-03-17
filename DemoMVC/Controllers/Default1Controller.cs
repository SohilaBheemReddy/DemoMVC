using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class Default1Controller : Controller
    {
        // GET: Default1
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Extract()
        {
            int eno = int.Parse(Request.QueryString["E"]);
            EMPDATA E = DBOperations.Extract(eno);
            return View("Index",E);
        }
        public ActionResult Update(EMPDATA E)
        {
            string S = DBOperations.UpdateEmp(E);
            ViewBag.S = S;
            return View("Index");
        }
    }
}