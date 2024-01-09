using BYDPlatform.Domain.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BYDPlatform.EntityFrameworkCore.EntityFrameWorkCore;

public class EntityFrameworkCoreBYDPlatformDbSchemaMigrator
    :IBYDPlatformDbSchemaMigrator
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBYDPlatformDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        await _serviceProvider
            .GetRequiredService<BYDPlatformDbContext>()
            .Database
            .MigrateAsync();
    }
}