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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupMembership>().HasKey(x => new {x.PersonID, x.GroupID});

            modelBuilder.Entity<GroupMembership>()
                .HasOne(m => m.Person)
                .WithMany(p => p.GroupMemberships)
                .HasForeignKey(m => m.PersonID);

            modelBuilder.Entity<GroupMembership>()
                .HasOne(m => m.Group)
                .WithMany(g => g.GroupMemberships)
                .HasForeignKey(m => m.GroupID);
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Group> Group { get; set; }
    }
}
