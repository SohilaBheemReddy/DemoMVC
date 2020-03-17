using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class EventsExController : Controller
    {
        // GET: EventsEx
        public ActionResult Index()
        {
            //Step1
            //retrive all dept data
            ViewBag.EL = DBOperations.getEmps();
            return View();
        }
        public ActionResult GetData()
        {
            int Eno = int.Parse(Request.QueryString["E"]);
           ViewBag.msg= DBOperations.DeleteEmp(Eno);
            ViewBag.EL= DBOperations.getEmps();
            return View("Index");
        }
    }
}