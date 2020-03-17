using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class Emp
    {
        private int empno;
        private string ename;
        private double salary;

        public int Empno { get => empno; set => empno = value; }
        public string Ename { get => ename; set => ename = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}