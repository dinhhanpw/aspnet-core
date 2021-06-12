using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using pwabp.Configuration;
using pwabp.Web;

namespace pwabp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class pwabpDbContextFactory : IDesignTimeDbContextFactory<pwabpDbContext>
    {
        public pwabpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<pwabpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            pwabpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(pwabpConsts.ConnectionStringName));

            return new pwabpDbContext(builder.Options);
        }
    }
}
