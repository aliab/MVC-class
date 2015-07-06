using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var ii=3;


            int i = 0;
            long j = i;
            //j = "sadf";
            //j.Name = "asd";

            //object o1 = j;
            //int l2 = (int)o1;
            
            ////

            //dynamic d1 = 3;
            //dynamic d2 = "234";
            //dynamic d3 = d1;
            
            
            //dynamic d4 = new Shape();
            //Shape d5 = new Shape();



            //d4.a = 2;//OK
            //int iii =(int) d1;



            //d1.a = 2;//ERROR
            







            //...
            return View("Home");
        }


        [ActionName("About")]
        public ActionResult ViewAbout(string dep = "Accounting", int? empId = null)
        {
            var empList = new List<int> { 1, 2, 3, 4, 5 };

            //GET EMPLOYEE BY DEP
            ViewBag.Department = dep;
            return empId.HasValue ? View("Emp") : View(empList);
        }
    }
}