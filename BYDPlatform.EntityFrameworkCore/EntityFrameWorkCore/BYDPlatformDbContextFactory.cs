using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BYDPlatform.EntityFrameworkCore.EntityFrameWorkCore;

public class BYDPlatformDbContextFactory
    :IDesignTimeDbContextFactory<BYDPlatformDbContext>
{
    public BYDPlatformDbContext CreateDbContext(string[] args)
    {
        BYDPlatformEFCoreEntityExtensionMappings.Configure();
        var configuration = BuildConfiguration();
        var builder = new DbContextOptionsBuilder<BYDPlatformDbContext>()
            .UseMySql(configuration.GetConnectionString("Default"), 
                MySqlServerVersion.LatestSupportedServerVersion);
        return new BYDPlatformDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../BYDPlatform.Http.Host/"))
            .AddJsonFile("appsettings.json", optional: false);
        return builder.Build();
    }
}