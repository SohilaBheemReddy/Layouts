using Layouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layouts.Controllers
{
    public class BindingController : Controller
    {
        // GET: Binding
        [ActionName("Example")]

        public ActionResult Sample()
        {
            return View("sample");
        }
        public ActionResult Index()
        {
            return View();

        }
        //primitive type
        public ActionResult Update(int id)

        {
            return View("Index", dboperations.GetEmpupdate(id));
        }
        // //complex type
        // [HttpPost]
        // public ActionResult Update(EMPDATA E)

        // {
        //     return View();
        // }
        //// basic type[not suggested]
        // [HttpPost]
        // public ActionResult Update(int EMPNO,String ENAME,String JOB,int MGR,DateTime HIREDATE,int SAL,int COMM,int DEPTNO)
        // {
        //     return View();
        // }
        ////form collections
        //[HttpPost]
        //public ActionResult Update(FormCollection F)
        // {
        //     int eno = int.Parse(F["EMPNO"]);
        //     string en =F["ENAME"];
        //     return View();

            //with bind
            [HttpPost]
        public ActionResult Update([Bind(Include="ENAME,JOB,DEPTNO")] EMPDATA E)
            {
            return View();
        }
        
    }
}