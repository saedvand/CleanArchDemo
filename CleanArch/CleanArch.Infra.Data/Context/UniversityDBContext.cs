using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    //Installing Microsoft.EntityFrameworkCore
    //Installing Microsoft.EntityFrameworkCore.Design
    //Installing Microsoft.EntityFrameworkCore.SqlServer
    //Installing Microsoft.EntityFrameworkCore.Tools
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
    }
}
