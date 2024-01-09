using BYDPlatform.Application.Contracts;
using BYDPlatform.Domain.Shared.Localization;
using Localization.Resources.AbpUi;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;

namespace BYDPlatform.Http.Api;
[DependsOn(
    typeof(AbpAspNetCoreMvcModule),
    typeof(ApplicationContractsModule)
    )]
public class HttpApiModule:AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }
    
    private void ConfigureLocalization()

    {

        // 配置本地化资源库

        Configure<AbpLocalizationOptions>(options => {

            options.Resources

                .Get<MyLocalizationResource>()

                .AddBaseTypes(typeof(AbpUiResource));

        });

    }
}