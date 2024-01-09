using BYDPlatform.Http.Api;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BYDPlatform.Http.Host;

public class Program
{
    public static async Task<int> Main(string[] args)
    {
        try
        {
            var builder = WebApplication.CreateBuilder(args);

            await builder.AddApplicationAsync<HttpHostModule>();

            var app = builder.Build();
            await app.InitializeApplicationAsync();
            
            
            await app.RunAsync();
            return 0;
        }
        catch (Exception e)
        {
            if (e is HostAbortedException)
            {
                throw;
            }

            return 1;
        }
    }
}