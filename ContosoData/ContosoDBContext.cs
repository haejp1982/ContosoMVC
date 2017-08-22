using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ContosoModels;

namespace ContosoData
{
    public class ContosoDBContext : DbContext
    {
        public ContosoDBContext() : base("Name = ContosoMVC")
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignment { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}

