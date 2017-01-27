using PeaceApp.Data.Entity.CoursesAndStudents;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeaceApp.Data.Entity.Students
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }
       

        public DateTime CreatedDatetime { get; set; }

        public virtual ICollection<CoursesInStudents> CoursesInStudents { get; set; }
    }
}
