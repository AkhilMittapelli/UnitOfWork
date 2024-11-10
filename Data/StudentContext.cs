using Microsoft.EntityFrameworkCore;
using UnitOfWork.Model;

namespace UnitOfWork.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) :base(options) 
        {
            
        }

        public DbSet<Student>  Students { get; set; }

        public DbSet<Mark> Marks { get; set; }
    }
}
