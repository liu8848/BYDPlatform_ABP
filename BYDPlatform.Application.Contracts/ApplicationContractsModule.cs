using BYDPlatform.Domain.Shared;
using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace BYDPlatform.Application.Contracts;

[DependsOn(typeof(AbpDddApplicationContractsModule),
    typeof(DomainSharedModule)
    )]
public class ApplicationContractsModule:AbpModule
{
    
}