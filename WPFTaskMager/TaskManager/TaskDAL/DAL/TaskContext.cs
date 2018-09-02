using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using TaskDAL.Models;

namespace TaskDAL.DAL
{
    public class TaskContext : DbContext
    {
        public TaskContext()
        {
            
        }

        public override int SaveChanges()
        {
            Debug.WriteLine("Saving Changes");
            return base.SaveChanges();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=TaskDb;User=SA; Password=Strongpassword1");
        }
        
        public virtual DbSet<Task> Tasks { get; set; }
    }
}