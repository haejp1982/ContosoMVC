using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoModels;
using ContosoService;
using ContosoMVC.ViewModels;

namespace ContosoMVC

{
    [HandleError]
    //[LogActionFilter]
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            //int i = 0;
            //int x = 1;
            //int z = x / 1;

            DepartmentService service = new DepartmentService();
            List<Department> dept = service.GetAllDepartment();
            return View(dept);
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Department dept)
        {
            if (ModelState.IsValid)
            {
                DepartmentService service = new DepartmentService();
                service.CreateDepartment(dept);
                return RedirectToAction("Index");
            }
            else
            {
                return View(dept);
            }

        }

        public ActionResult Details(int Id)
        {
            DepartmentService service = new DepartmentService();
            var dept = service.GetById(Id);
            return View(dept);

        }

        public ActionResult Edit(int Id)
        {
            DepartmentService service = new DepartmentService();
            var dept = service.GetById(Id);
            return View(dept);

        }

        [HttpPost]
        public ActionResult Edit(Department dept)
        {
            DepartmentService service = new DepartmentService();
            service.Update(dept);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int Id)
        {
            DepartmentService service = new DepartmentService();
            var dept = service.GetById(Id);
            return View(dept);

        }



        [HttpPost]
        public ActionResult Delete(Department dept)
        {
            DepartmentService service = new DepartmentService();
            service.Delete(dept);
            return RedirectToAction("Index");

        }

        public ActionResult CreateDepartmentCourse()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateDepartmentCourse(DepartmentCourseViewModel model)
        {
            DepartmentService departmentService = new DepartmentService();
            Department dept = new Department();
            dept.Name = model.DepartmentName;
            dept.Budget = Convert.ToDecimal(model.DepartmentBudget);


            CourseService courseService = new CourseService();
            Course course = new Course();
            course.Title = model.CourseName;
            courseService.CreateCourse(course);

            return View();
        }
    }
}