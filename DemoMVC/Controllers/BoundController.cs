using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class BoundController : Controller
    {
        // GET: Bound
        public ActionResult Index()
        {
            Emp E = new Emp();
            return View(E);
        }

        public ActionResult Display(Emp A)
        {
            return View(A);
        }


        public ActionResult Index1()
        {
            Emp E = new Emp();
            return View(E);
        }
        [HttpPost]
        public ActionResult Index1(Emp E)
        {
            return View("Display",E);
        }
        public ActionResult UnBound()
        {
            return View();
        }
        public ActionResult Showdata()
        {
            Emp E = new Emp();
            E.Empno = int.Parse(Request.Form["txtEmpno"]);
            E.Ename = Request.Form["txtEname"];
            E.Salary = double.Parse(Request.Form["txtSalary"]);

            return View(E);
        }


    }
}