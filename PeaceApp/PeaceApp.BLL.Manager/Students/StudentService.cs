using PeaceApp.Data.Entity.Students;
using PeaceApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeaceApp.BLL.Manager.Students
{
    public class StudentService
    {
        public Repository<Student> StudentRepository;

        public StudentService()
        {
            StudentRepository = new Repository<Student>();
        }


        public StudentDTO Add(StudentDTO studentDto)
        {
            if (studentDto == null)
            {
                return null;
            }

            var student = new Student()
            {
                Name = studentDto.Name,
                Age = studentDto.Age,
                LastName = studentDto.LastName,
                CreatedDatetime = DateTime.Now
            };

            StudentRepository.Add(student);
            StudentRepository.SaveChanges();

            studentDto.Id = student.Id;


            return studentDto;

        }

    }
}
