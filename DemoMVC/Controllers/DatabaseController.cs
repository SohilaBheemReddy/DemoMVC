using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class DatabaseController : Controller
    {
        static List<DEPTDATA> list = null;
        // GET: Database
       
        public ActionResult Index()
        {
            EMPDATA E = new EMPDATA();
            return View(E);
        }
        [HttpPost]
        public ActionResult Index(EMPDATA E)
        {
           ViewBag.msg= DBOperations.InsertEmp(E);
            return View();
        }
        public ActionResult getDeptData()
        {
            return View();
        }
        public ActionResult GetDept()
        {
            int deptno = int.Parse(Request.Form["txtDeptno"]);
            List<EMPDATA> L=DBOperations.GetDept(deptno);
            return View("getDeptData",L);
        }
        public ActionResult getDepts()
        {
            list = DBOperations.getDepts();
            ViewBag.DL = list;
            return View();

        }
        public ActionResult SendDept()
        {
            int deptno = int.Parse(Request.QueryString["d"]);
            ViewBag.DL = list;
            ViewBag.S = deptno;
            List<EMPDATA> EL=DBOperations.GetDept(deptno);
            return View("getDepts",EL);
        }




    }
}