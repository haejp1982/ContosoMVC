using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoService;
using ContosoModels;

namespace ContosoMVC.Controllers
{
    public class PersonController : Controller
    {
        PersonService service;
        public PersonController()
        {
         service = new PersonService();
        }
        // GET: Person
        public ActionResult Index()
        {
            List<Person> per = service.GetAll();
            return View(per);
        }
        public ActionResult Create()
        {

            return View();

        }
        [HttpPost]

        public ActionResult Create(Person person)
        {

            service.CreatePerson(person);
            return RedirectToAction("Index");

        }

        public ActionResult Delete(int Id)
        {
            var person = service.GetByID(Id);
            return View(person);

        }
        [HttpPost]
        public ActionResult Delete(Person person)
        {

            service.Delete(person);
            return RedirectToAction("Index");

        }

        public ActionResult Details(int id)
        {
            var per = service.GetByID(id);
            return View(per);

        }

        public ActionResult Edit(int id)
        {
            service.GetByID(id);
            return View();

        }
        [HttpPost]
        public ActionResult Edit(Person person)
        {

            service.Update(person);
            return RedirectToAction("Index");

        }
    }
}