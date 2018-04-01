using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using ASPNetCoreAngularApp2.Authorization.Roles;
using ASPNetCoreAngularApp2.Authorization.Users;
using ASPNetCoreAngularApp2.Configuration;
using ASPNetCoreAngularApp2.Localization;
using ASPNetCoreAngularApp2.MultiTenancy;
using ASPNetCoreAngularApp2.Timing;

namespace ASPNetCoreAngularApp2
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ASPNetCoreAngularApp2CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            ASPNetCoreAngularApp2LocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = ASPNetCoreAngularApp2Consts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNetCoreAngularApp2CoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
