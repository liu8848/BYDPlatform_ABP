using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace BYDPlatform.Domain.Shared.Data;

public class BYDPlatformDbMigrationService:ITransientDependency
{
    private readonly IEnumerable<IBYDPlatformDbSchemaMigrator> _dbSchemaMigrators;
    // private readonly ITenantRepository _tenantRepository;
    private readonly ICurrentTenant _currentTenant;
}