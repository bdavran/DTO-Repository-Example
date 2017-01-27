using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PeaceApp.Data.Entity.CoursesAndStudents;

namespace PeaceApp.Data.Entity.Courses
{
   public class Course
    {

        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string CourseName { get; set; }

        public int Grade { get; set; }

        public virtual ICollection<CoursesInStudents> CoursesInStudents { get; set; }
    }
}
