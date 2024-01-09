using Volo.Abp.Threading;

namespace BYDPlatform.EntityFrameworkCore.EntityFrameWorkCore;

/// <summary>
/// 读取全局配置
/// </summary>
public class BYDPlatformGlobalFeatureConfigurator
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        OneTimeRunner.Run(() =>
        {
            
        });
    }
}