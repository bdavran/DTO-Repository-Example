using PeaceApp.Data.Entity.Courses;
using PeaceApp.Data.Entity.CoursesAndStudents;
using PeaceApp.Data.Entity.Students;
using System.Data.Entity;


namespace PeaceApp.Data.Context
{
    public class PeacAppContext : DbContext
    {
        public PeacAppContext()
            :base("PeaceApp.ConnectionString")
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CoursesInStudents> CoursesInStudents { get; set; }
    }
}
