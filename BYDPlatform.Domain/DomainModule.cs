using BYDPlatform.Domain.Shared;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace BYDPlatform.Domain;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(DomainSharedModule)
    )]
public class DomainModule:AbpModule
{
    
}