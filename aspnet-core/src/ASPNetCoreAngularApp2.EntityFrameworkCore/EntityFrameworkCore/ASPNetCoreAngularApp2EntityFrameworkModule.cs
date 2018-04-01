using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using ASPNetCoreAngularApp2.EntityFrameworkCore.Seed;

namespace ASPNetCoreAngularApp2.EntityFrameworkCore
{
    [DependsOn(
        typeof(ASPNetCoreAngularApp2CoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class ASPNetCoreAngularApp2EntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<ASPNetCoreAngularApp2DbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        ASPNetCoreAngularApp2DbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        ASPNetCoreAngularApp2DbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ASPNetCoreAngularApp2EntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
