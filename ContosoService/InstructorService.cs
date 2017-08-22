using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoData;
using ContosoModels;

namespace ContosoService
{
    public class InstructorService
    {
        InstructorRepository repository;

        public InstructorService()
        {
            repository = new InstructorRepository();
        }

        public void CreateInstructor(Instructor obj)
        {
            repository.Create(obj);

        }

        public List<Instructor> GetAllInstructor()
        {

            var inst = repository.GetAll();
            return inst;
        }

        public Instructor GetById(int Id)
        {

            return repository.GetById(Id);
        }

        public void Update(Instructor inst)
        {
            repository.Update(inst);

        }

        public void Delete(Instructor inst)
        {

            repository.Delete(inst);
        }

    }
}
