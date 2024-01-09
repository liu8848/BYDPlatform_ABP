using BYDPlatform.Application.Contracts;
using BYDPlatform.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace BYDPlatform.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EntityFrameworkCoreModule),
    typeof(ApplicationContractsModule)
    )]
public class BYDPlatformDbMigratorModule:AbpModule
{
    
}