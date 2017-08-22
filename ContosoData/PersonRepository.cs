using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoModels;
using System.Data.Entity;


namespace ContosoData
{
    public class PersonRepository : IRepository<Person>
    {
        public void Create(Person entity)
        {
            using (var db = new ContosoDBContext())
            {
                db.People.Add(entity);
                db.SaveChanges();

            }
        }

        public void Delete(Person entity)
        {
            using (var db = new ContosoDBContext())
            {

                var person = db.People.Where(d => d.Id == entity.Id).FirstOrDefault();

                if (person != null)
                {
                    db.People.Remove(person);
                    db.SaveChanges();
                }
                   
            }
        }

        public List<Person> GetAll()
        {
            using (var db = new ContosoDBContext())
            {
                var person = db.People.ToList();
                return person;
                

            }
        }

        public Person GetById(int Id)
        {
            using (var db = new ContosoDBContext())
            {
                var person = db.People.Where(p => p.Id == Id).FirstOrDefault();
                return person;


            }
        }

        public void Update(Person entity)
        {
            using (var db = new ContosoDBContext())
            {
                db.People.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();

            }
        }
    }
}
