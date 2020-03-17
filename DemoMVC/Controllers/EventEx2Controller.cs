using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{//with Submit button

    public class EventEx2Controller : Controller
    {
        // GET: EventEx2
        public ActionResult Index()
        {
            ViewBag.EL = DBOperations.getEmps();
            return View();
        }
        public ActionResult DelEmp()
        {
            int eno = int.Parse(Request.Form["ddlEmpno"]);
            ViewBag.msg = DBOperations.DeleteEmp(eno);
            ViewBag.EL = DBOperations.getEmps();
            return View("Index");
            
        }



    }
}