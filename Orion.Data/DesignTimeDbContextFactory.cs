using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Orion.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OrionDbContext>
    {
        public OrionDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OrionDbContext>();

            builder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=password;Database=Orion;");

            return new OrionDbContext(builder.Options);
        }
    }
}