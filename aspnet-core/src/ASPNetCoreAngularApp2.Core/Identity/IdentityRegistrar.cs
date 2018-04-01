using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ASPNetCoreAngularApp2.Authorization;
using ASPNetCoreAngularApp2.Authorization.Roles;
using ASPNetCoreAngularApp2.Authorization.Users;
using ASPNetCoreAngularApp2.Editions;
using ASPNetCoreAngularApp2.MultiTenancy;

namespace ASPNetCoreAngularApp2.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
