using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class DBClass
    {
      static   DemoEntities1 D = new DemoEntities1();
        public static string InsertEmp(EmpSal E)

        {
            try
            {
                D.EmpSals.Add(E);
                D.SaveChanges();
                return "1 row inserted";
            }
            catch (DbUpdateException Ex)
            {
                SqlException S = Ex.GetBaseException() as SqlException;
                return S.Message;
           
            }

        }
        public static EmpSal getEmp(int Empno)
        {
            var E = from E1 in D.EmpSals
                    where E1.Empno == Empno
                    select E1;
            return E.First();
        }
    }
}