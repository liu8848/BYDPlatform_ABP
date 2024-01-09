using Volo.Abp.Application.Services;

namespace BYDPlatform.Application.Services;

public interface IHelloService:IApplicationService
{
    Task<string> GetHelloAsync();
}