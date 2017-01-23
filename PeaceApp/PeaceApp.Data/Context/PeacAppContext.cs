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
    }
}
