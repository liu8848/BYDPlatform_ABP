using BYDPlatform.Domain;
using BYDPlatform.EntityFrameworkCore.EntityFrameWorkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.Modularity;

namespace BYDPlatform.EntityFrameworkCore;

[DependsOn(typeof(AbpEntityFrameworkCoreMySQLModule),
    typeof(DomainModule)
    )]
public class EntityFrameworkCoreModule:AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        BYDPlatformEFCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<BYDPlatformDbContext>(options =>
        {
            options.AddDefaultRepositories(includeAllEntities: true);
        });
        
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default =
                "Server=localhost;Port=3306;Database=BYDPlatform;Uid=root;Pwd=sudalu929;";
        });
        
        Configure<AbpDbContextOptions>(options =>
        {
            options.UseMySQL();
        });
    }
}