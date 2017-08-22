using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoModels;

namespace ContosoData
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        List<T> GetAll();
        void Delete(T entity);
        T GetById(int Id);
        void Update(T entity);

    }
}
