using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NimbleCalandar.Configuration;
using NimbleCalandar.Web;

namespace NimbleCalandar.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class NimbleCalandarDbContextFactory : IDesignTimeDbContextFactory<NimbleCalandarDbContext>
    {
        public NimbleCalandarDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NimbleCalandarDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            NimbleCalandarDbContextConfigurer.Configure(builder, configuration.GetConnectionString(NimbleCalandarConsts.ConnectionStringName));

            return new NimbleCalandarDbContext(builder.Options);
        }
    }
}
