using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Orion.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<OrionDbContext>
    {
        public DesignTimeDbContextFactory(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IConfiguration Configuration { get; }
        
        public OrionDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OrionDbContext>();

            builder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));

            return new OrionDbContext(builder.Options);
        }
    }
}