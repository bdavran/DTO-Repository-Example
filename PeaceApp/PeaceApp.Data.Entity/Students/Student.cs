using System;
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

        public enum Gender
        {
            Male = 1,
            Female = 2
        }

        public DateTime CreatedDatetime { get; set; }
    }
}
