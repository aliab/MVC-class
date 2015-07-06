using FirstMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMvcApp.Controllers
{
    //[MyCustomFilter]
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var list = Student.GetAll();
            //ViewBag.StudentCount = list.Count();
            ViewData["StudentCount"] = list.Count();
            return View(list);
        }

        public ActionResult NewStudent()
        {
            return View("New");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewStudent([Bind(Exclude = "Mark")]Student st, string password)
        {
            //Save Student
            return RedirectToAction("StudentList", new { message = "Successfull!!" });
        }
        public int PageSize = 5;


        public ActionResult StudentList(int page = 0, string message = "")
        {
            ViewBag.Message = message;

            ViewBag.Page = page;
            var list = Student.GetAll().Skip(page * PageSize).Take(PageSize);
            return View(list);
        }

        public ActionResult MyList()
        {
            return View(Student.GetAll());
        }
        public ActionResult ViewStudent(int id)
        {

            return View(Student.GetAll()[id]);
        }

        public PartialViewResult ViewFullInfo(int id)
        {

            return PartialView("StudentInfoView", Student.GetAll()[id]);
        }

        public JsonResult GetFullInfo(int id)
        {
            var s = Student.GetAll()[id];
            return Json(new { Name = s.Name, LastName = s.LastName }, JsonRequestBehavior.AllowGet);
        }
    }
}