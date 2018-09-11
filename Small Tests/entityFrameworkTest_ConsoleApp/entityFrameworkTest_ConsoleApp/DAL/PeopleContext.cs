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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>().HasKey(r => new {r.PersonID, r.CourseID});

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Person)
                .WithMany(p => p.Registrations)
                .HasForeignKey(r => r.PersonID);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Registrations)
                .HasForeignKey(r => r.CourseID);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Professor)
                .WithMany(p => p.CoursesTeaching)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>()
                .HasOne(p => p.PersonAddress)
                .WithMany(a => a.People);
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}