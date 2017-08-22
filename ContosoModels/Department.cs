using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModels
{
    public class Department
    {
        public int Id { get; set; }
        [DisplayName("Department Name")]
        [Required(ErrorMessage ="Please enter valid Departement Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter the Budget")]
        public decimal? Budget { get; set; }
        public DateTime? StartDate { get; set; }
        [DisplayName("Instructor Id")]
        public int InstructorId { get; set; }
        public byte?[] RowVersion { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }


        public Instructor Instructor { get; set; }
        public ICollection<Course> Courses { get; set; }


    }
}
