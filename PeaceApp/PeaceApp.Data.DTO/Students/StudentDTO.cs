using System;

namespace PeaceApp.Data.Entity.Students
{
    public class StudentDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

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
