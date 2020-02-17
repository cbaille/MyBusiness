using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyBusiness.Configuration;
using MyBusiness.Web;

namespace MyBusiness.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyBusinessDbContextFactory : IDesignTimeDbContextFactory<MyBusinessDbContext>
    {
        public MyBusinessDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyBusinessDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyBusinessDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyBusinessConsts.ConnectionStringName));

            return new MyBusinessDbContext(builder.Options);
        }
    }
}
