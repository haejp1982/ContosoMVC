﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoModels
{
    public class Student
    {
        [Key]
        [ForeignKey("Person")]
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public Person Person { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

