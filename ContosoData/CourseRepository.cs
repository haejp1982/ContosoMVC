using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoModels;
using System.Data.Entity;

namespace ContosoData
{
    public class CourseRepository : IRepository<Course>
    {
        public void Create(Course entity)
        {
            using (var db = new ContosoDBContext())
            {
                db.Course.Add(entity);
                db.SaveChanges();

            }
        }

        public void Delete(Course entity)
        {
            using (var db = new ContosoDBContext())
            {
                var cor = db.Course.Where(c => c.Id == entity.Id).FirstOrDefault();
                if (cor != null)
                {
                    db.Course.Remove(entity);
                    db.SaveChanges();

                }

            }
        }

        public List<Course> GetAll()
        {
            using (var db = new ContosoDBContext())
            {
                return db.Course.ToList();

            }


        }

        public Course GetById(int Id)
        {
            using (var db = new ContosoDBContext())
            {

                var cor = db.Course.Where(c => c.Id == c.Id).FirstOrDefault();
                return cor;

            }
        }

        public void Update(Course entity)
        {
            using (var db = new ContosoDBContext())
            {
                db.Course.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }

    }
}
