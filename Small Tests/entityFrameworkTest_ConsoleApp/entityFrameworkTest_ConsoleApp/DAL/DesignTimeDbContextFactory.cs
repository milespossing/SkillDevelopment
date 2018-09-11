using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace entityFrameworkTest_ConsoleApp.DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PeopleContext>
    {
        public PeopleContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptions<PeopleContext>();
            return new PeopleContext(builder);
        }
    }
}