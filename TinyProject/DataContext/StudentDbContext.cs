using Microsoft.EntityFrameworkCore;
using TinyProject.Models.Domain;

namespace TinyProject.DataContext
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<StudentModel>? Students { get; set; }
    }
}
