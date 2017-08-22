using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoData;
using ContosoModels;

namespace ContosoService
{
    public class DepartmentService
    {
        DepartmentRepository repository;

        public DepartmentService()
        {
            repository = new DepartmentRepository();
        }

        public void CreateDepartment(Department obj)
        {
            repository.Create(obj);

        }

        public List<Department> GetAllDepartment()
        {

            var dept = repository.GetAll();
            return dept;
        }

        public Department GetById(int Id)
        {

            return repository.GetById(Id);
        }

        public void Update(Department dept)
        {
            repository.Update(dept);

        }

        public void Delete(Department dept)
        {

            repository.Delete(dept);
        }
    }

}
