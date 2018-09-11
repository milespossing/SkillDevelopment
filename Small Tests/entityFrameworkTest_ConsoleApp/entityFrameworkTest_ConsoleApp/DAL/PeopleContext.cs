using entityFrameworkTest_ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;

namespace entityFrameworkTest_ConsoleApp.DAL
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TestDatabase1; User Id=SA; Password=<YourStrong!Passw0rd>;");
        }

        public DbSet<Person> People { get; set; }
    }
}