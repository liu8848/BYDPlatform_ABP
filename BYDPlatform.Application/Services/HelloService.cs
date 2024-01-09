using Volo.Abp.Application.Services;

namespace BYDPlatform.Application.Services;

public class HelloService:ApplicationService,IHelloService
{
    public async Task<string> GetHelloAsync()
    {
        return await Task.FromResult("hello");
    }
}