
using Layouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Layouts.Models
{
    public class dboperations
    {
        static DemoEntities D = new DemoEntities();
        public static bool get(string username, string password)
        {
            var v = from E in D.TblLogins
                    where E.Username == username
                    && E.Password == password
                    select E;
            if (v.ToList().Count == 1)
                return true;
            else
                return false;
        }
        //public static List<EMPDATA> GetAll()
        //{
        //    var E = from E1 in D.EMPDATAs
        //            select E1;
        //    return E.ToList();
        //}
        public static EMPDATA GetEmpupdate(int Empno)
        {
            var LE = from L in D.EMPDATAs
                     where L.EMPNO == Empno
                     select L;
            return LE.FirstOrDefault();
        }
        public static string GetEmpnoData(EMPDATA emp)
        {
            var LE = from L in D.EMPDATAs
                     where L.EMPNO == emp.EMPNO
                     select L;
            foreach (var row in LE)
            {
                row.JOB = emp.JOB;
                row.MGR = emp.MGR;
                row.SAL = emp.SAL;
                row.COMM = emp.COMM;
                row.DEPTNO = emp.DEPTNO;
            }
            D.SaveChanges();
            return "1 Row Updated";
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
        public static List<EMPDATA> GetAll()
        {
            var e = from l in D.EMPDATAs
                    select l;
            return e.ToList();
        }

        public static List<EMPDATA> GetEmpList(int[] id)
        {
            var e = from l in D.EMPDATAs
                    where id.Contains(l.EMPNO) == true
                    select l;
            return e.ToList();
        }

    }
}
