using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoModels;
using ContosoService;

namespace ContosoMVC.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {

            CourseService service = new CourseService();
            List<Course> cor = service.GetAllCourse();
            return View(cor);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Course cor)
        {
            CourseService service = new CourseService();
            service.CreateCourse(cor);
            return RedirectToAction("Index");

        }

        public ActionResult Details(int Id)
        {
            CourseService service = new CourseService();
            var cor = service.GetByID(Id);
            return View(cor);

        }

        public ActionResult Edit(int Id)
        {
            CourseService service = new CourseService();
            var cor = service.GetByID(Id);
            return View(cor);

        }

        [HttpPost]
        public ActionResult Edit(Course cor)
        {
            CourseService service = new CourseService();
            service.UpdateCourse(cor);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int Id)
        {
            CourseService service = new CourseService();
            var cor = service.GetByID(Id);
            return View(cor);

        }



        [HttpPost]
        public ActionResult Delete(Course cor)
        {
            CourseService service = new CourseService();
            service.DeleteCourse(cor);
            return RedirectToAction("Index");

        }
    }
}