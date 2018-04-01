using Abp.MultiTenancy;
using ASPNetCoreAngularApp2.Authorization.Users;

namespace ASPNetCoreAngularApp2.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
