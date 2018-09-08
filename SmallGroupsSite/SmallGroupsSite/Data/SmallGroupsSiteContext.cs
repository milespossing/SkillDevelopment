using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmallGroupsSite.Models;

namespace SmallGroupsSite.Models
{
    public class SmallGroupsSiteContext : DbContext
    {
        public SmallGroupsSiteContext (DbContextOptions<SmallGroupsSiteContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SmallGroups;User Id=SA;Password=<YourStrong!Passw0rd>");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        
        //}

        public DbSet<Person> Person { get; set; }
        public DbSet<Group> Group { get; set; }
    }
}
