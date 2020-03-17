using Layouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Layouts.Controllers
{
    public class crudeController : Controller
    {
        // GET: crude
      
            public ActionResult Index()
            {
                List<EMPDATA> L = dboperations.GetAll();
                return View(L);
            }
            public ActionResult Create()
            {
                return View();
            }
            public ActionResult Edit(int id)
            {
                EMPDATA E = dboperations.GetEmpupdate(id);
                return View(E);
            }
            public ActionResult Update(EMPDATA E)
            {


                string m = dboperations.GetEmpnoData(E);
                ViewBag.res = m;
                return View();
            }
            public ActionResult Delete(int id)
            {
                ViewBag.msg = dboperations.DeleteEmp(id);
                return View();
            }
        }
    }

    
