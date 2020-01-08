using Microsoft.EntityFrameworkCore;

namespace SalaryBook.Entities
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<SalaryType> salaryTypes { get; set; }
    }
}
