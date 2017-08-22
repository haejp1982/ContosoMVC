using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoModels;
using System.Data.Entity;
namespace ContosoData
{
    public class InstructorRepository : IRepository<Instructor>
    {
        public void Create(Instructor entity)
        {
            using (var db = new ContosoDBContext())
            {
                db.Instructors.Add(entity);
                db.SaveChanges();

            }
        }

        public void Delete(Instructor entity)
        {
            using (var db = new ContosoDBContext())
            {
                var inst = db.Instructors.Where(ins => ins.Id == entity.Id).FirstOrDefault();
                if (inst != null)
                {
                    db.Instructors.Remove(inst);
                    db.SaveChanges();

                }

            }
        }

        public List<Instructor> GetAll()
        {
            using (var db = new ContosoDBContext())
            {
                return db.Instructors.ToList();
                
            }
        }

        public Instructor GetById(int Id)
        {
            using (var db = new ContosoDBContext())
            {
                var inst = db.Instructors.Where(ins => ins.Id == Id).FirstOrDefault();
                return inst;

            }
        }

        public void Update(Instructor entity)
        {
            using (var db = new ContosoDBContext())
            {
                db.Instructors.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }
    }
}
