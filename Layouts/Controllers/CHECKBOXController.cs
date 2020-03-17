using Layouts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Layouts.Controllers
{
    public class CHECKBOXController : Controller
    {
        // GET: CHECKBOX



        public ActionResult Index()
        {
            List<EMPDATA> L1 = dboperations.GetAll();
            return View(L1);
        }
        public ActionResult getSelected(int[] ch)
        {
            
            List<EMPDATA> l =dboperations.GetEmpList(ch);
            return View(l);
        }

       
    }
}
