using BYDPlatform.Application.Contracts;
using BYDPlatform.Domain;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace BYDPlatform.Application;

[DependsOn(typeof(AbpAutoMapperModule),
    typeof(AbpDddApplicationModule),
    typeof(DomainModule),
    typeof(ApplicationContractsModule)
    )]
public class ApplicationModule:AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //配置自动映射
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ApplicationModule>();
        });
    }
}