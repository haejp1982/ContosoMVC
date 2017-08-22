using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoData;
using ContosoModels;

namespace ContosoService
{
    public class PersonService
    {
        PersonRepository repository;

        public PersonService()
        {
            repository = new PersonRepository();
        }

        public void CreatePerson(Person person)
        {

            repository.Create(person);

        }
        public List<Person> GetAll()
        {

            var person = repository.GetAll();
            return person;

        }

        public Person GetByID(int Id)
        {
            return repository.GetById(Id);            

        }

        public void Delete(Person person)
        {
            repository.Delete(person);

        }


        public void Update(Person person)
        {

            repository.Update(person);

        }

    }
}
