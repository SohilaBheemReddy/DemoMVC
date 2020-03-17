using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DemoMVC.Models
{
    public class DBOperations
    {
        static DemoEntities D = new DemoEntities();
        
        public static string InsertEmp(EMPDATA A)
        {
            try
            {
                D.EMPDATAs.Add(A);
                D.SaveChanges();
            }
            catch (DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
                if (ex.Message.Contains("FK__EmpDept"))
                {
                    return "No Proper Deptno";
                }
                else if (ex.Message.Contains("EMP_PK"))
                {
                    return "Empno cannot be duplicate";
                }
                else
                    return "Error Occured";
            }
            return "1 row inserted";
        }
        public static List<EMPDATA> GetDept(int Deptno)
        {
            var LE = from L in D.EMPDATAs
                     where L.DEPTNO==Deptno
                     select L;
            return LE.ToList();
        }
        public static List<DEPTDATA> getDepts()
        {
            var dept = from D1 in D.DEPTDATAs
                       select D1;
            return dept.ToList();
        
        }
        public static List<EMPDATA> getEmps()
        {
            var emp = from E1 in D.EMPDATAs
                       select E1;
            return emp.ToList();

        }

        public static EMPDATA Empdata(int Empno)
        {
            var LE = from L in D.EMPDATAs
                     where L.EMPNO == Empno
                     select L;
            return LE.First();
        }
        public static string DeleteEmp(int Eno)
        {
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO == Eno
                    select E1;
            D.EMPDATAs.Remove(E.First());
            D.SaveChanges();
            return Eno + " Employee details are deleted";
        }

        public static EMPDATA Extract(int Empno)
        {
            var E = from E1 in D.EMPDATAs
                    where E1.EMPNO==Empno
                    select E1;
            return E.First();
        }

        public static string UpdateEmp(EMPDATA E)
        {
            var emp = from E1 in D.EMPDATAs
                      where E1.EMPNO == E.EMPNO
                      select E1;
            EMPDATA e = emp.First();
            e.ENAME = E.ENAME;
            e.MGR = E.MGR;
            e.SAL = E.SAL;
            D.SaveChanges();
            return " 1 Row updated";
        
        
        }
    }
}