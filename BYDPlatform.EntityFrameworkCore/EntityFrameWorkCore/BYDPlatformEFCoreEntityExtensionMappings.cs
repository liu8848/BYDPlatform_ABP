using Volo.Abp.Threading;

namespace BYDPlatform.EntityFrameworkCore.EntityFrameWorkCore;

public static class BYDPlatformEFCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        BYDPlatformGlobalFeatureConfigurator.Configure();
        BYDPlatformModuleExtensionConfigurator.Configure();
        
        OneTimeRunner.Run(() =>
        {
            
        });
    }
}