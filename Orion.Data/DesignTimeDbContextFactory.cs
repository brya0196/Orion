using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Orion.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OrionDbContext>
    {
        public OrionDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OrionDbContext>();

            var connectionString = "Host=localhost;Port=5432;Username=postgres;Password=password;Database=Orion;";
            
            builder.UseNpgsql(connectionString);

            return new OrionDbContext(builder.Options);
        }
    }
}