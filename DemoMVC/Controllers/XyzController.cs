using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class XyzController : Controller
    {
        // GET: Xyz
        public ActionResult Index()
        {
            ViewBag.str = "My First MvvvvvVC Project";
            ViewData["str1"] = "My First Project";
            TempData["str2"] = "My Project";
            return View();
        }
        public ActionResult SendObject()
        {
            Emp E = new Emp();
            E.Empno = 100;
            E.Ename = "Ram";
            E.Salary = 5000;

            return View(E);
        }
        public ActionResult SendObjects()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;

            E = new Emp();
            E.Empno = 1;
            E.Ename = "AAA";
            E.Salary = 5000;
            L.Add(E);

            E = new Emp();
            E.Empno = 2;
            E.Ename = "BBB";
            E.Salary = 6000;
            L.Add(E);
            return View(L);

        }
        public ActionResult SendObjectVB()
        {
            Emp E = null;

            E = new Emp();
            E.Empno = 1;
            E.Ename = "AAA";
            E.Salary = 5000;
            ViewData["xyz"] = E;
            return View();

        }
        public ActionResult SendObjectsVB()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "AAA";
            E.Salary = 5000;
            L.Add(E);

            E = new Emp();
            E.Empno = 2;
            E.Ename = "BBB";
            E.Salary = 6000;
            L.Add(E);
            ViewData["xyz"] = L;

            return View();
        }
        public ActionResult SendObjectVBView()
        {
            Emp E = null;

            E = new Emp();
            E.Empno = 1;
            E.Ename = "AAA";
            E.Salary = 5000;
            return View(E);
        }

        public ActionResult SendObjectsVBView()
        {
            List<Emp> L = new List<Emp>();
            Emp E = null;
            E = new Emp();
            E.Empno = 1;
            E.Ename = "AAA";
            E.Salary = 5000;
            L.Add(E);

            E = new Emp();
            E.Empno = 2;
            E.Ename = "BBB";
            E.Salary = 6000;
            L.Add(E);


            return View(L);
        }

        public ActionResult BoundCtrl()
        {
            EmpSal E = new EmpSal();

            return View(E);
        }
       [HttpPost]
        public ActionResult BoundCtrl(EmpSal E)
        {
            string msg=DBClass.InsertEmp(E);
            ViewBag.msg = msg;
            return View();
        }
        public ActionResult UnBoundCtrl()
        {
            return View();
        }
        public ActionResult UnBoundCtrl1()
        {
            EmpSal S = new EmpSal();
            S.Empno = int.Parse(Request.Form["txtEmpno"]);
            S.Ename = Request.Form["txtEname"];
            S.Salary = int.Parse(Request.Form["txtSalary"]);
            string msg = DBClass.InsertEmp(S);
            ViewBag.msg = msg;
            return View("UnBoundCtrl");
        }
        public ActionResult Extract()
        {
            EmpSal E = new EmpSal();
            return View();
        }
        public ActionResult ExtractEmp()
        {

            int Eno = int.Parse(Request.QueryString["E"]);
            EmpSal E = DBClass.getEmp(Eno);
            return View("Extract",E);
        }
    }
}