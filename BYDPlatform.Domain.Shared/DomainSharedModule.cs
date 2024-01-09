using BYDPlatform.Domain.Shared.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace BYDPlatform.Domain.Shared;

[DependsOn(typeof(AbpLocalizationModule))]
public class DomainSharedModule:AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //配置虚拟文件系统
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DomainSharedModule>();
        });
        
        //配置全球化资源文件
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources.Add<MyLocalizationResource>("zh-Hans")
                .AddVirtualJson("/Localization/MyLocalization");

            options.DefaultResourceType = typeof(MyLocalizationResource);
        });
        
        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace("MyLocalization",typeof(MyLocalizationResource));
        } );
        
        base.ConfigureServices(context);
    }
}