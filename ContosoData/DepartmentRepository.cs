using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoModels;
using System.Data.Entity;

namespace ContosoData
{
    public class DepartmentRepository : IRepository<Department>
    {
        public void Create(Department entity)
        {
            using (var db = new ContosoDBContext())
            {
                db.Departments.Add(entity);
                db.SaveChanges();
            }
        }


        public List<Department> GetAll()
        {
            using (var db = new ContosoDBContext())
            {
                return db.Departments.ToList();

            }
        }


        public void Delete(Department entity)
        {
            using (var db = new ContosoDBContext())
            {
                var dep = db.Departments.Where(d => d.Id == entity.Id).FirstOrDefault();
                if (dep != null)
                {
                    db.Departments.Remove(dep);
                    db.SaveChanges();

                }

            }
        }

        public Department GetById(int Id)
        {
            using (var db = new ContosoDBContext())
            {
                var dep = db.Departments.Where(d => d.Id == Id).FirstOrDefault();
                return dep;
            }
        }

        public void Update(Department entity)
        {
            using (var db = new ContosoDBContext())
            {
                db.Departments.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
