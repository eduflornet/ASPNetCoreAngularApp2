using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ASPNetCoreAngularApp2.Configuration;
using ASPNetCoreAngularApp2.Web;

namespace ASPNetCoreAngularApp2.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ASPNetCoreAngularApp2DbContextFactory : IDesignTimeDbContextFactory<ASPNetCoreAngularApp2DbContext>
    {
        public ASPNetCoreAngularApp2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ASPNetCoreAngularApp2DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ASPNetCoreAngularApp2DbContextConfigurer.Configure(builder, configuration.GetConnectionString(ASPNetCoreAngularApp2Consts.ConnectionStringName));

            return new ASPNetCoreAngularApp2DbContext(builder.Options);
        }
    }
}
