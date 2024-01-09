namespace BYDPlatform.Domain.Shared.Data;

public interface IBYDPlatformDbSchemaMigrator
{
    Task MigrateAsync();
}