using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoData;
using ContosoModels;

namespace ContosoService
{
    public class CourseService
    {
        CourseRepository repository;

        public CourseService()
        {
            repository = new CourseRepository();
        }
        public void CreateCourse(Course course)
        {
            repository.Create(course);

        }
        public List<Course> GetAllCourse()
        {
            var cor = repository.GetAll();
            return cor; 

        }

        public Course GetByID(int id)
        {
            return repository.GetById(id);

        }

        public void UpdateCourse(Course course)
        {
            repository.Update(course);

        }

        public void DeleteCourse(Course course)
        {

            repository.Delete(course);


        }
    } 
}
