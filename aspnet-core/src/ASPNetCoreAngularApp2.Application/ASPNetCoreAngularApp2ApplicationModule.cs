using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASPNetCoreAngularApp2.Authorization;

namespace ASPNetCoreAngularApp2
{
    [DependsOn(
        typeof(ASPNetCoreAngularApp2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ASPNetCoreAngularApp2ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ASPNetCoreAngularApp2AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ASPNetCoreAngularApp2ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
