using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using ASPNetCoreAngularApp2.Authorization.Users;
using ASPNetCoreAngularApp2.Editions;

namespace ASPNetCoreAngularApp2.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
